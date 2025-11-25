<?php

class SolidCP_API extends HB_Module {

    public function hello($params) {
        return array(
            'status' => 1,
            'message' => 'Hello from SolidCP API!',
            'input' => $params
        );
    }

    public function getdomainlicenses($params) {
        $clientId = intval($params['clientid']);

        $domains = HB::DB()->getAll("
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
WHERE D.client_id = $clientId
ORDER  BY D.name;",
            array($clientId)
        );

        return array(
            'status' => 1,
            'services' => $domains
        );
    }
}
?>