-- Remove the previous key, which we accidentally linked to characters.accountId
ALTER TABLE `vars_accounts` DROP FOREIGN KEY `vars_accounts_ibfk_1`;

-- Remove entries for accounts that no longer exist, to make sure the new
-- constraint won't fail
DELETE va
FROM `vars_accounts` AS va
LEFT JOIN `accounts` AS a ON va.`accountId` = a.`accountId`
WHERE a.`accountId` IS NULL;

-- Add the new constraint to remove variables together with their accounts
ALTER TABLE `vars_accounts` ADD CONSTRAINT `vars_accounts_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts`(`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;
