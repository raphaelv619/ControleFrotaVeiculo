# ControleFrotaVeiculo
Este é um trabalho de faculdade no qual deve ser feito um sistema para gerenciar a frota de veículos de uma empresa. No momento o software possuí 4 funcionalidades prontas, que permitem  entre outras coisas, cadastrar veículos e motoristas e cadastrar viagens e entrada e saída para os veículos e motoristas. As instruções para rodar o programa estão no arquivo README.

*** TUTORIAL DE PASSOS PARA RODAR O PROGRAMA ***

1 - Baixar ou clonar o repositório.

2 - Executar ou abrir o arquivo "ControleFrotaDeVeiculos.sln", que se encontra na pasta raíz do repositório.

3 - Com o projeto aberto no Visual Studio, ir até a aba "Projeto" e selecionar a opção "Propriedades de ControleFrotaDeVeiculos...".

4 - Dentro dessa opção tem a "Estrutura de destino", que deve ser ".NET Framework 4.6.1" ou superior.

*** TUTORIAL DE PASSOS PARA CONFIGURAR A BASE DE DADOS ***

1 - Abrir o MySQL Workbench e selecionar a opção "Data Import/Restore" que se encontra na aba "Administration" do "Navigator".

2 - Selecionar a opção "Import from Dump Project Folder" e importar a pasta "Dump20190601" que se encontra na pasta raíz do repositório.

3 - Com o projeto aberto no Visual Studio, ir até a pasta models e abrir a classe "DAL".

4 - No construtor da classe tem a string de conexão, que deve ser alterada para as suas configurações de user e senha MySQL.

*** Pastas do Repositório ***

. "Dump20190601" contém o banco de dados

. "screens" contém a tela de Login e o Form principal da aplicação.

. "UserControls" contém todos os User Control's que são carregados no Form Principal.

. "models" contém todas as classes que são utilizadas no projeto.



