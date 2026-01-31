-- Add index on partyId column in characters table for improved query performance
-- when loading party members and finding characters by party
CREATE INDEX IF NOT EXISTS `idx_partyId` ON `characters` (`partyId`);
