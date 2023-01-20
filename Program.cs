using POO_List;


var casaLista = new List<Casa>();

for (int i = 0; i < 7; i++)
{
    // Variáveis do escopo
    int largura, altura, tamanho, quantidadeDePortas, quantidadeDeJanelas; String cor; decimal valorCasa;
    String rua, bairro, cep, numero;
    var inputTipoDeRua = 0;

    // Instância objeto e struct respectivamente
    Casa casaObjeto = new Casa();
    Endereco endereco = new Endereco();

    //Recebendo valores
    Console.WriteLine("Insira a largura da casa:    ");
    largura = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Insira o comprimento da casa:    ");
    altura = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Insira a cor da casa:    ");
    cor = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Insira a quantidade de portas da casa:    ");
    quantidadeDePortas = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Insira a quantidade de janelas:    ");
    quantidadeDeJanelas = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Insira o valor da casa:    ");
    valorCasa = Convert.ToDecimal(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Insira a rua da casa:    ");
    rua = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Insira o bairro da casa:    ");
    bairro = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Insira o CEP da casa:    ");
    cep = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Insira o numero da casa:    ");
    numero = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("- - - - - - - - - - - - - - ");
    Console.WriteLine("Escolha um tipo de rua");
    Console.WriteLine("Escolha um tipo de rua");
    Console.WriteLine("0 = Asfaltada");
    Console.WriteLine("1 = Estrada de Barro");
    Console.WriteLine("2 = Paralelepipido");
    Console.WriteLine("- - - - - - - - - - - - - - ");
    inputTipoDeRua = Convert.ToInt32(Console.ReadLine());

    Console.Clear();
    switch (inputTipoDeRua)
    {
        case 0:
            endereco.TipoRuaEnum = TipoRuaEnum.Asfaltada;
        break;
        case 1:
            endereco.TipoRuaEnum = TipoRuaEnum.EstradaDeBarro;
        break;
        case 2:
            endereco.TipoRuaEnum = TipoRuaEnum.Paralelepipido;
        break;
    }

    //Utilizando metódo CalcularArea
    tamanho = casaObjeto.CalcularArea(largura, altura);

    //Atribuindo valor ao Struct
    endereco.Rua = rua;
    endereco.Bairro = bairro;
    endereco.Cep = cep;
    endereco.Numero = numero;

    //Atribuindo valores ao Objeto
    casaObjeto.Tamanho = tamanho;
    casaObjeto.Cor = cor;
    casaObjeto.QuantidadeDePortas = quantidadeDePortas;
    casaObjeto.QuantidadeDeJanelas = quantidadeDeJanelas;
    casaObjeto.ValorCasa = valorCasa;
    casaObjeto.EnderecoCasa = endereco;

    //Adiciona o objeto na lista
    casaLista.Add(casaObjeto);
    casaObjeto.InformacaoSobreCasa();
    Console.ReadLine();
    Console.Clear();
}


