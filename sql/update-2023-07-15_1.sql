CREATE TABLE `account_properties` (
  `propertyId` bigint(20) NOT NULL,
  `accountId` bigint(20) NOT NULL,
  `name` varchar(64) NOT NULL,
  `type` varchar(1) NOT NULL,
  `value` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `account_properties`
  ADD PRIMARY KEY (`propertyId`),
  ADD KEY `accountId` (`accountId`);

ALTER TABLE `account_properties`
  MODIFY `propertyId` bigint(20) NOT NULL AUTO_INCREMENT;

ALTER TABLE `account_properties`
  ADD CONSTRAINT `account_properties_ibfk_1` FOREIGN KEY (`accountId`) REFERENCES `accounts` (`accountId`) ON DELETE CASCADE ON UPDATE CASCADE;
