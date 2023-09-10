# Desafio Stefanini

Endpoints:
Pedido/GetPedidos - Retorna todos os pedidos.<br>
Pedido/GetPedido - Recebe um id e retorna o pedido em específico.<br>
Pedido/NovoUpdatePedido - Recebe um json modelo de pedido, caso id passado seja 0 cria um novo Pedido, caso seja diferente de 0, procura o pedido pelo id e edita.<br>
Pedido/DeletePedido - Recebe o id de um pedido, procura o pedido pelo id e deleta da base de dados.<br>

## Arquitetura:
Controllers, modelos de resposta e requisição em Application<br>
Interfaces de services, interfaces de repositórios e implementação de services em Domain<br>
Context do banco, modelos das tabelas e implementação de repositórios em Infra<br>
