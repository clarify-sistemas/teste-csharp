#!/bin/bash

# Exibir informações de depuração
echo "Iniciando o contêiner PostgreSQL..."
echo "Usuário: $POSTGRES_USER"
echo "Banco de dados: $POSTGRES_DB"

# Iniciar o servidor PostgreSQL
pg_ctl -D /var/lib/postgresql/data -l logfile start

# Manter o contêiner em execução
tail -f /dev/null