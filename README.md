# CRUD_EF_SqLite_Migrations
Crud em C# utilizando Entity framework , SqLite , Migrations.

# Migração

Criar uma migração. Gerar um código que pode atualizar o banco de dados para sincronizá-lo com um conjunto de alterações do modelo.

Atualizar o banco de dados. Aplicar migrações pendentes para atualizar o esquema de banco de dados.

Personalizar o código de migração. Às vezes, o código gerado precisa ser modificado ou complementado.

Remover uma migração. Excluir o código gerado.

Reverter uma migração. Desfazer as alterações do banco de dados.

Gerar scripts SQL. Talvez seja necessário um script para atualizar um banco de dados de produção ou para solucionar problemas de código de migração.

Aplicar migrações em runtime. Quando as atualizações de tempo de design e a execução de scripts não forem as melhores opções, chame o método Migrate().


# 1.Criar uma migração: 
  Add-Migration InitialCreate

# 2.Atualizar o banco de dados:
  Update-Database

# 3.Personalizar o código de migração:
  Add-Migration AddProductReviews

# 4.Remover uma migração:
  Remove-Migration
  Update-Database LastGoodMigration
  
# 5.Gerar scripts SQL:
  Script-Migration
 
# 6.Aplicar migrações em runtime:
  myDbContext.Database.Migrate();



Ver mais em:
https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=vs




