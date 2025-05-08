# DIODesafio-Estacionamento
Desafio da DIO do módulo de Sintaxe do C# do curso de .NET da Randstad

O objetivo era criar uma aplicação console que permitiria o usuário calcular o tempo de estadia de um carro num estacionamento fictício, seguindo os seguintes critérios
- [X] Cadastrar um veículo no estacionamento
- [X] Remover um veículo do estacionamento, exibindo o cálculo total de sua estadia
- [X] Listar todos os carros estacionados

Foi utilizado uma classe de Veiculo para as operações, e também foi acrescentado uma verificação de placas válidas conforme modelos pré-2019 (ABC-XXXX)
O intuito de utilizar uma classe específica para isso era para facilitar futuras operações como ao invés de utilizar o input do usuário para definir as horas decorridas, isso seria feito automaticamente, e salvo na própria classe do veículo, além de poder incluir especificação de modelos de veículos, como Carro, Moto, Caminhão, etc.
