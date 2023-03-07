
int num1= 0;
while (num1 <=10){
    Console.WriteLine(num1);
    num1 = num1 + 2;
}


int num2 = 0;
do{
    Console.WriteLine(num2);
    num2 = num2 + 3;
}
while (num2 <=15);


for (int num3 = 0; num3 <= 5; num3++){
    Console.WriteLine(num3);
}

for (int num4 = 0; num4 <=20; num4 = num4 + 5){
    Console.WriteLine(num4);
}

//exercicio MENU
string opcao;
do{
Console.WriteLine("Olá, por favor digite umas das opções: ");
Console.WriteLine("1- Avançar ");
Console.WriteLine("2- Direita ");
Console.WriteLine("3- Esquerda ");
Console.WriteLine("4-Sair ");
opcao = Console.ReadLine();
} while (!(opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4"));


int idade;
Console.WriteLine("Olá, por favor digite a sua idade:");
bool conseguiuConverter = int.TryParse(Console.ReadLine(), out idade);
Console.WriteLine("conseguiu converter = " + conseguiuConverter);
Console.WriteLine("idade =  " + idade);
Console.WriteLine("parabéns, muito obrigada, bom saber hahahahah");

int ano;
Console.WriteLine("vc nasceu em que ano? ");
while (!int.TryParse(Console.ReadLine(), out ano)){
    Console.WriteLine("Digite sua ano em numeral, não por extenso , obrigada...");
}
Console.WriteLine("Vc nasceu em =  " + ano);
Console.WriteLine("temos musica:  Hoje o tempo voa amor escorre pelas mãos...kkkkk");

//Arrays


Console.WriteLine("Arrays com numeros inteiros");
int [ ] array = new int [3];

array [0] = 10;
array [1] = 50;
array [2] = 18;
Console.WriteLine("Aprendendo sobre Arrays 1º exemplo, arrays com inteiros");
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);
Console.WriteLine("imprima " + array[0]+ "," + array[1]+ ","  + array[2]);

Console.WriteLine("partiu Arrays com strings...");

string [ ] arrays = new string [5];
Console.WriteLine("Qual o seu nome completo?");
arrays [0] = "Anita";
arrays [1] = "Elaine";
arrays [2] = "Brito";
arrays [3] = "de";
arrays [4] = "Carvalho";
Console.WriteLine("Aprendendo sobre Arrays 2º exemplo, arrays com strings");
//Console.WriteLine(arrays [0]);
//Console.WriteLine(arrays [1]);
//Console.WriteLine(arrays [2]);
//Console.WriteLine(arrays [3]);
//Console.WriteLine(arrays [4]);
Console.WriteLine("Meu nome completo é:  " + arrays[0] + " " + arrays[1] + " " + arrays[2]+ " " + arrays[3] + " " + arrays [4]); 

//outro exemplo


string [] nomes = new string [2];
Console.WriteLine("Digite seu primeiro nome:");
nomes[0] = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome");
nomes[1] = Console.ReadLine();
Console.WriteLine("seu nome é:  " + nomes[0] + " " + nomes[1]);


string [] nomes2 = new string [3];
for(int i = 0; i < 3; i++){
Console.WriteLine($"digite nome: {i+1}");
nomes2[i] = Console.ReadLine();
    }

    for(int i = 0; i < 3; i++){
    Console.WriteLine($"Nome {i+1}: {nomes2[i]}");
    }


//codigo com um pouco menos risco de quebra  


int tamanhoArray = 3;
string [] nomes1 = new string [tamanhoArray];
for(int i = 0; i < tamanhoArray; i++){
    Console.WriteLine($"digite o nome {i+1}:");
    nomes1[i]= Console.ReadLine();
}
for(int i = 0; i < tamanhoArray; i++){
    Console.WriteLine($"Nome {i+1}: {nomes1[i]}");
}




int Vejamos = 4;

string [] nomeee = new string [Vejamos];
for(int i = 0; i < Vejamos; i++){
Console.WriteLine($"digite nome: {i+1}");
nomeee[i] = Console.ReadLine();
    }

    for(int i = 0; i < Vejamos; i++){
    Console.WriteLine($"Nome {i+1}: {nomeee[i]}");
    }

