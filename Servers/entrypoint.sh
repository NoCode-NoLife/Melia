#!/bin/bash

# Wait for MySQL to be ready
until mysql --host=127.0.0.1 --user=root --password=${MYSQL_ROOT_PASSWORD} -e "SELECT 1"; do
    echo "Waiting for MySQL..."
    sleep 3
done

# Run all SQL files
for file in /docker-entrypoint-initdb.d/*.sql; do
    echo "Executing $file..."
    mysql --host=127.0.0.1 --user=root --password=${MYSQL_ROOT_PASSWORD} < "$file"
done

# Run the default entrypoint
exec "$@"
