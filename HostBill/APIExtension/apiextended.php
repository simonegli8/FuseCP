<?php

require_once '../includes/config.php';

$api_key = '8a94c00674bbd64dc504';

$id = $_POST['api_id'] ?? null;
$key = $_POST['api_key'] ?? null;
$cmd = $_POST['call'] ?? null;
$clientId = $_POST['clientid'] ?? null;

function DB() {
    global $db_engine, $db_host, $db_port, $db_name, $db_user, $db_pass;

    if ($db_engine !== 'mysql') {
        http_response_code(500);
        echo json_encode(["error" => "Unsupported database engine: $db_engine"]);
        exit;
    }

    try {
        $pdo = new PDO("mysql:host=$db_host;port=$db_port;dbname=$db_name;charset=utf8", $db_user, $db_pass);
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    } catch (PDOException $e) {
        http_response_code(500);
        echo json_encode(["error" => "Database connection failed"]);
        exit;
    }
    return $pdo;
}

if (isset($id) && isset($key) && isset($cmd) && isset($clientId) && $cmd == "getDomainLicenses") {
    $pdo = DB();
    $stmt = $pdo->prepare("SELECT * FROM hb_api_access");
    $stmt->execute();
    $rows = $stmt->fetchAll(PDO::FETCH_ASSOC);
    $i = 0;
    while ($i < count($rows) && ($rows[$i]['api_id'] != $id || $api_key != $key)) {
        $i++;
    }
    if ($i < count($rows)) {
    } else {
        http_response_code(403);
        echo json_encode(["error" => "Invalid API credentials", "db" => $rows, "key" => $key ]);
        exit;
    }
    header("Content-Type: application/json");
    header("Access-Control-Allow-Origin: *"); // Optional for CORS

    try {
        $stmt = $pdo->prepare(<<<TXT
SELECT D.name AS Name, A.qty AS Quantity, P.name AS Product FROM hb_domains AS D
LEFT JOIN (

	SELECT parent_id AS account_id, child_id AS domain_id FROM hb_accounts_relations 
	WHERE parent_type = 'Hosting' AND child_type = 'Domain'
	UNION 
	SELECT child_id AS account_id, parent_id AS domain_id FROM hb_accounts_relations 
	WHERE child_type = 'Hosting' AND parent_type = 'Domain'
)	
	AS R ON D.id = R.domain_id
LEFT JOIN hb_accounts AS A ON R.account_id = A.id
LEFT JOIN hb_products AS P ON A.product_id = P.id
WHERE D.client_id = $clientId;
TXT);
        $stmt->execute();
        $rows = $stmt->fetchAll(PDO::FETCH_ASSOC);

        echo json_encode(["success" => true, "domains" => $rows]);

    } catch (Exception $e) {
        http_response_code(500);
        echo json_encode(["error" => "Query failed"]);
    }
} else {
    http_response_code(400);
    echo json_encode(["error" => "Missing parameters"]);
    exit;
}
?>