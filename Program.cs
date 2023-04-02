//declara as variáveis do tipo int
int valorc, vpago, troco;

//exibe a mensagem "Digite o valor da compra:" no console
Console.WriteLine("Digite o valor da compra: ");
//Lê o valor digitado pelo usuário e converte para o 
//tipo int, atribuindo-o para a variável valorc
valorc = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor pago: ");
vpago = Convert.ToInt32(Console.ReadLine());

//Cálculo do valor do troco, subtraindo o valor da compra 
//do valor pago e armazenando o resultado na variável troco.
troco = (vpago - valorc);
Console.WriteLine($"Seu troco é: {troco}");