# Imagem oficial do PostgreSQL
FROM postgres:latest

# Variáveis de ambiente para o banco de dados
ENV POSTGRES_USER=admin
ENV POSTGRES_PASSWORD=admin
ENV POSTGRES_DB=teste_cfy

# Copiar o script SQL para dentro do container
# O PostgreSQL executará automaticamente os arquivos .sql no diretório /docker-entrypoint-initdb.d/
COPY ./init.sql /docker-entrypoint-initdb.d/

# Adicionar um script de inicialização para depuração
COPY ./start.sh /start.sh
RUN chmod +x /start.sh

# Comando para iniciar o servidor PostgreSQL
CMD ["/start.sh"]
