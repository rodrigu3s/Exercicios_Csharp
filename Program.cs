using System;

namespace APS_Romulo {
    class Program {
        static void Main(string[] args) {

            int contador1, contador2, questao;

            contador1 = 0;

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Ciência da Computação - IPESU       Turma = 2019.1\n");
            Console.WriteLine("Projeto - Linguagem de programação estruturada\n");
            Console.WriteLine("Aluno: João Rodrigues");
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Questões de 1º à 22º: ");
            Console.WriteLine();
            Console.WriteLine("Escolha uma das questão abaixo ou digite '0' para sair: ");
            Console.WriteLine();

            contador2 = 12;
            
            for (contador1 = 1; contador1 <= 11; contador1++) {
                Console.WriteLine($" Questão [{contador1}]             Questão [{contador2}]");
                contador2++;
            }

            Console.WriteLine();



            Console.Write("Qual a questão? ");
            questao = int.Parse(Console.ReadLine());

            while (questao != 0) {

                if (questao == 99) {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine(" Projeto - Linguagem de programação estruturada");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Questões de 1º à 22º: ");
                    Console.WriteLine();

                    contador2 = 12;

                    for (contador1 = 1; contador1 <= 11; contador1++) {
                        Console.WriteLine($" Questão [{contador1}]             Questão [{contador2}]");
                        contador2++;
                    }
                }




                if (questao == 99) {
                    Console.WriteLine();
                    Console.Write("Qual a próxima questão? Ou tecle '0' para SAIR! ");
                    questao = int.Parse(Console.ReadLine());
                }

                if (questao == 1) { Console.Clear(); Questao1(); }
                if (questao == 2) { Console.Clear(); Questao2(); }
                if (questao == 3) { Console.Clear(); Questao3(); }
                if (questao == 4) { Console.Clear(); Questao4(); }
                if (questao == 5) { Console.Clear(); Questao5(); }
                if (questao == 6) { Console.Clear(); Questao6(); }
                if (questao == 7) { Console.Clear(); Questao7(); }
                if (questao == 8) { Console.Clear(); Questao8(); }
                if (questao == 9) { Console.Clear(); Questao9(); }
                if (questao == 10) { Console.Clear(); Questao10(); }
                if (questao == 11) { Console.Clear(); Questao11(); }
                if (questao == 12) { Console.Clear(); Questao12(); }
                if (questao == 13) { Console.Clear(); Questao13(); }
                if (questao == 14) { Console.Clear(); Questao14(); }
                if (questao == 15) { Console.Clear(); Questao15(); }
                if (questao == 16) { Console.Clear(); Questao16(); }
                if (questao == 17) { Console.Clear(); Questao17(); }
                if (questao == 18) { Console.Clear(); Questao18(); }
                if (questao == 19) { Console.Clear(); Questao19(); }
                if (questao == 20) { Console.Clear(); Questao20(); }
                if (questao == 21) { Console.Clear(); Questao21(); }
                if (questao == 22) { Console.Clear(); Questao22(); }
                if (questao == 0) {
                    Console.WriteLine("Obrigado por estudar conosco! BYEBYE");
                }
                if (questao != 0) {
                    questao = 99;
                }
            }

            Console.ReadKey();


        }

        public static void Questao1() {

            Console.WriteLine("1º) Escrever um algoritmo que leia o nome e as três notas obtidas por um aluno durante o semestre.\n Calcular a sua média(aritmética), informar o nome e sua menção aprovado (media >= 7), Reprovado(media <= 5) e Recuperação(media entre 5.1 a 6.9). ");
            Console.WriteLine();

            string aluno;
            double nota1 = 0, nota2 = 0, nota3 = 0, media = 0;

            Console.WriteLine("Informe Nome do Aluno: ");
            aluno = Console.ReadLine();
            Console.WriteLine("Informe a Primeira Nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Segunda Nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Terceira Nota: ");
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine();
            Console.WriteLine($"A Média de {aluno} é {media.ToString("F")}");
            if (media >= 7)
                Console.WriteLine($"{aluno} foi Aprovado ");

            else if (media <= 5)
                Console.WriteLine($"{aluno} foi Reprovado ");

            else if (media > 5 && media < 7)
                Console.WriteLine($"{aluno} está em Recuperação ");
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao2() {
            int numero1, numero2;

            Console.WriteLine("2º) Escrever um algoritmo que leia dois valores inteiros distintos e informe qual é o maior.");
            Console.WriteLine();
            Console.WriteLine("Informe um Número Inteiro: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro Número Inteiro: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
                Console.WriteLine($"{numero1} é o Maior Número Digitado!");

            else if (numero1 == numero2)
                Console.WriteLine("Números Iguais");

            else
                Console.WriteLine($"{numero2} é o Maior Número Digitado");
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao3() {
            string sexo;

            Console.WriteLine("3º) Elabore um algoritmo que leia do teclado o sexo de uma pessoa. Se o sexo digitado for M\n ou F, escrever na tela “Sexo válido!”. Caso contrário, informar “Sexo inválido!” ");
            Console.WriteLine();
            Console.WriteLine("Informe ( F ) para Feminino ou ( M ) para Masculino");
            Console.Write("Digite Aqui: ");
            sexo = Console.ReadLine();

            if (sexo.ToUpper() == "F" || sexo.ToUpper() == "M")
                Console.WriteLine("Sexo Válido!");

            else
                Console.WriteLine("Sexo Inválido!");
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao4() {

            double numero1, numero2, opcao, media, diferenca1, diferenca2, produto, divisao;

            Console.WriteLine("4º) Faça um programa que receba dois números e execute as operações listadas a seguir de\n acordo com a escolha do usuário.\n Se a opção digitada for invalida, mostrar uma mensagem de erro e terminar a execução do \n programa.Lembre - se de que na operação 4 o segundo número deve ser diferente de zero.");
            Console.WriteLine();
            Console.WriteLine("Informe o Primeiro Número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo Número: ");
            numero2 = double.Parse(Console.ReadLine());
            media = (numero1 + numero2) / 2;
            diferenca1 = numero1 - numero2;
            diferenca2 = numero2 - numero1;
            produto = numero1 * numero2;
            divisao = numero1 / numero2;
            opcao = 1;

            while (opcao != 0) {

                Console.WriteLine("\n********************************************\n" +
                                    " 1 - Média entre Número Digitados \n" +
                                    " 2 - Diferença do Maior Para o Menor \n" +
                                    " 3 - Produto entre os Números Digitados \n" +
                                    " 4 - Divisão do Primeiro Número pelo Segundo \n" +
                                    " 0 - sair \n" +
                                  "********************************************\n");
                Console.Write("Digite Aqui: ");
                opcao = double.Parse(Console.ReadLine());

                if (opcao == 1)
                    Console.WriteLine("A Média entre os Números é " + media.ToString("f"));

                else if (opcao == 2) {
                    if (numero1 > numero2)
                        Console.WriteLine("A Diferença entre os Números é " + diferenca1);
                    else
                        Console.WriteLine("A Diferença entre os Números é " + diferenca2);
                } else if (opcao == 3)
                    Console.WriteLine("O Produto entre os Números é " + produto);

                else if (opcao == 4) {
                    if (numero2 == 0)
                        Console.WriteLine("Operação Invalida. O Segundo Número deve Ser Diferente de Zero");

                    else
                        Console.WriteLine("A divisão dos Números é " + divisao.ToString("f"));
                } else if (opcao == 0)
                    Console.WriteLine("Saindo");

                else
                    Console.WriteLine("Operação Inválida. Digite um Número Válido!");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();

        }
        public static void Questao5() {
            int numero1, numero2;

            Console.WriteLine("5º) Elabore um algoritmo que leia dois números inteiros e mostre o resultado da diferença do\n maior valor pelo menor. ");
            Console.WriteLine();
            Console.WriteLine("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro Número: ");
            numero2 = int.Parse(Console.ReadLine());

            DiferencaEntreNumeros diferenca = new DiferencaEntreNumeros { numero1 = numero1, numero2 = numero2 };

            diferenca.CalculaDiferenca();

            Console.WriteLine("Diferença = " + diferenca.resultado);

            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();

        }
        public static void Questao6() {
            double salario;

            Console.WriteLine("6º) Ume empresa decide dar um aumento de 30% aos funcionários com salários inferiores a\n R$ 500, 00.Faça um programa que receba o salário do funcionário e mostre o valor do\n salário reajustado ou uma mensagem, caso o funcionário não tenha direito ao aumento. ");
            Console.WriteLine();
            Console.WriteLine("Informe o valor do Salário: ");
            salario = double.Parse(Console.ReadLine());

            AumentoSalario aumento = new AumentoSalario {
                salario = salario
            };

            aumento.CalculaAumentoSalario();

            if (salario < 500)
                Console.WriteLine($"Aumento de 30%, Salário Atual = {aumento.calcula_Aumento}");
            else
                Console.WriteLine("Não tem Direito ao Aumento!");

            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao7() {
            double nota1; double nota2; double nota3; double nota4; string sexo; double mediaAlunos;
            Console.WriteLine("7º) Elabore um algoritmo para ler 4 notas de um aluno (de 1 a 10) e o sexo (M ou F) do aluno. Após calcular a média das notas, \napresentar a mensagem: Se for masculino, o resultado deverá ser precedido de “Caro aluno, seu resultado é: “. Se for feminino, o resultado deverá ser \nprecedido de “Cara aluna, seu resultado é: “. Se o aluno tiver obtido média maior ou igual a 6 está “Aprovado”, caso contrário, “Reprovado”.");
            Console.WriteLine();
            Console.WriteLine("Seja Bem vindo!");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Observação: Sua nota não pode ultrapassar o número 10!");
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Digite sua primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            if (nota1 <= 10) {
            } else {
                Console.WriteLine("Nota inválida! Sua nota deve ser menor ou igual a 10!");
            }

            Console.WriteLine("Digite sua segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            if (nota2 <= 10) {
            } else {
                Console.WriteLine("Nota inválida! Sua nota deve ser menor ou igual a 10!");
            }


            Console.WriteLine("Digite sua terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            if (nota3 <= 10) {
            } else {
                Console.WriteLine("Nota inválida! Sua nota deve ser menor ou igual a 10!");
            }

            Console.WriteLine("Digite sua quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            if (nota4 <= 10) {
            } else {
                Console.WriteLine("Nota inválida! Sua nota deve ser menor ou igual a 10!");
            }


            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("Observação: Digite a letra F se for do sexo feminino!");
            Console.WriteLine("Observação: Digite a letra M se for do sexo masculino!");
            Console.WriteLine("Qual o seu sexo? ");
            sexo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------");

            mediaAlunos = (nota1 + nota2 + nota3 + nota4) / 4;

            if (sexo.ToLower() == "f" && mediaAlunos >= 6) {
                Console.WriteLine("Cara aluna, seu resultado é {0}! Você está aprovada!", mediaAlunos);
            } else if (sexo.ToLower() == "f" && mediaAlunos < 6) {
                Console.WriteLine("Cara aluna, seu resultado é {0}! Você está Reprovada!", mediaAlunos);
            } else if (sexo.ToLower() == "m" && mediaAlunos >= 6) {
                Console.WriteLine("Caro aluno, seu resultado é {0}! Você está aprovado!", mediaAlunos);
            } else if (sexo.ToLower() == "m" && mediaAlunos < 6) {
                Console.WriteLine("Caro aluno, seu resultado é {0}! Você está reprovado!", mediaAlunos);
            } else {
                Console.WriteLine("Sexo inválido! Tente novamente!");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao8() {
            double horaAula; double salario; int nivel;
            Console.WriteLine("8º) A escola “APRENDER” faz o pagamento de seus professores por hora/aula. Faça um\n algoritmo que calcule e exiba o salário de um professor.Sabe - se que o valor da hora / aula\n segue a tabela abaixo: \na.Professor Nível 1 R$12, 00 por hora / aula \nb.Professor Nível 2 R$17, 00 por hora / aula \nc.Professor Nível 3 R$25, 00 por hora / aula ");
            Console.WriteLine();
            Console.WriteLine("Seja Bem vindo Professor!");
            Console.WriteLine("Quantas horas/aulas foram ministradas: ");
            horaAula = double.Parse(Console.ReadLine());

            Console.WriteLine("Você é professor nível 1, 2 ou 3?");
            nivel = int.Parse(Console.ReadLine());

            switch (nivel) {

                case 1:
                    salario = horaAula * 12.00;
                    Console.WriteLine("O seu salário é de {0}!", salario);
                    break;

                case 2:
                    salario = horaAula * 17.00;
                    Console.WriteLine("O seu salário é de {0}!", salario);
                    break;

                case 3:
                    salario = horaAula * 25.00;
                    Console.WriteLine("O seu salário é de {0}!", salario);
                    break;

                default:
                    Console.WriteLine("Nível do professor inválido! Tente novamente!");
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();

        }
        public static void Questao9() {
            int maior, menor, numero, contador;
            Console.WriteLine("9º) Elabore um algoritmo que leia 5 valores inteiros e apresente na tela o maior e o menor\n deles. ");
            Console.WriteLine();
            Console.WriteLine("Informe o 1º Número: ");
            numero = int.Parse(Console.ReadLine());
            maior = numero;
            menor = numero;
            contador = 1;

            for (contador = 2; contador <= 5; contador++) {
                Console.WriteLine("Informe o " + contador + "º Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < menor)
                    menor = numero;

                if (numero > maior)
                    maior = numero;
            }
            Console.WriteLine("O Maior Número é " + maior);
            Console.WriteLine("O Menor Número é " + menor);

            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao10() {
            double valorDoInvestimento; int tipoDoInvestimento; double rendimentoMensal;
            Console.WriteLine("10º) Uma agência bancária possui dois tipos de investimentos, conforme o quadro a seguir. Faça\n um algoritmo que receba o tipo de investimento e o valor do investimento e que calcule e\n mostre o valor corrigido de acordo com o tipo de investimento. ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Descrição        Tipo");
            Console.WriteLine("Poupança          2");
            Console.WriteLine("Renda Fixa        1");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Digite o valor do seu investimento: ");
            valorDoInvestimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o tipo de investimento? (1 ou 2)");
            tipoDoInvestimento = int.Parse(Console.ReadLine());

            if (tipoDoInvestimento == 1) {
                rendimentoMensal = valorDoInvestimento * 0.30;
                Console.WriteLine("O valor corrigido com o rendimento mensal é: R${0}", rendimentoMensal + valorDoInvestimento);
            } else if (tipoDoInvestimento == 2) {
                rendimentoMensal = valorDoInvestimento * 0.40;
                Console.WriteLine("O valor corrigido com o rendimento mensal é: R${0}", rendimentoMensal + valorDoInvestimento);
            } else {
                Console.WriteLine("Tipo de investimento inválido! ");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao11() {
            double numero;
            Console.WriteLine("11º) Faça um algoritmo que leia um número e mostre uma mensagem indicando se este\n número é par ou ímpar e se é positivo ou negativo.");
            Console.WriteLine();
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero < 0 && numero % 2 == 0) {
                Console.WriteLine("O número {0} é negativo e par", numero);
            } else if (numero < 0 && numero % 2 != 0) {
                Console.WriteLine("O número {0} é negativo e ímpar", numero);
            } else if (numero > 0 && numero % 2 == 0) {
                Console.WriteLine("O número {0} é positivo e par", numero);
            } else if (numero > 0 && numero % 2 != 0) {
                Console.WriteLine("O número {0} é positivo e ímpar", numero);
            } else {
                Console.WriteLine("O número 0 é nulo! ");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao12() {
            double lado1; double lado2; double lado3;
            Console.WriteLine("12º) Dados três valores X, Y e Z, verificar se eles podem ser os comprimentos dos lados de um\n triângulo e, se forem verificar se é um triângulo equilátero, isósceles ou escalenos.Se eles\n não formarem um triângulo, escrever a mensagem.Considere as seguintes propriedades:\n \na.O comprimento de cada lado em um triângulo é menor que a soma dos outros dois lados \nb.Equiláteros: tem os comprimentos dos três lados iguais \nc.Isósceles: tem os comprimentos de dois lados iguais \nd.Escaleno: tem os comprimentos dos três lados diferentes.");
            Console.WriteLine();
            Console.WriteLine("digite seu primeiro valor: ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite seu segundo valor: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite seu terceiro valor: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2 && lado1 != 0 && lado2 != 0 && lado3 != 0) {
                if (lado1 == lado2 && lado1 == lado3) {
                    Console.WriteLine("seu triângulo é equilátero, pois todos os lados são iguais!");
                } else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3) {
                    Console.WriteLine("seu triângulo é isósceles, pois possui apenas dois lados iguais!");
                } else {
                    Console.WriteLine("seu triângulo é escaleno, pois possui todos os lados diferentes!");
                }
            } else {
                Console.WriteLine("com os valores digitados não é possível formar um triângulo!");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao13() {
            double altura; string sexoDaPessoa; double pesoIdeal;
            Console.WriteLine("13º) Construa um algoritmo que calcule o peso ideal de uma pessoa. Dados de entrada: altura e\n sexo.Fórmulas para cálculo do peso:\n \na.peso ideal de homem = (72, 7 x altura) -58 \nb.peso ideal da mulher = (62, 1 x altura) -44,7");
            Console.WriteLine();
            Console.WriteLine("Informe a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Observação: Digite a letra F se for do sexo feminino!");
            Console.WriteLine("Observação: Digite a letra M se for do sexo masculino!");
            Console.WriteLine("Informe o seu sexo: ");
            sexoDaPessoa = Convert.ToString(Console.ReadLine());


            if (sexoDaPessoa.ToLower() == "f") {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("O peso ideal da mulher é: {0}", pesoIdeal);
            } else if (sexoDaPessoa.ToLower() == "m") {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("O peso ideal do homem é: {0}", pesoIdeal);
            } else {
                Console.WriteLine("Sexo inválido!");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao14() {
            int idade;
            Console.WriteLine("14º) Faça um programa que receba a idade de um nadador e mostre a sua categoria usando as\n regras a seguir.");
            Console.WriteLine();
            Console.WriteLine("Idade do Nadador: ");
            idade = int.Parse(Console.ReadLine());

            CategoriadeNadador categoria = new CategoriadeNadador { idade = idade };
            categoria.CalculaCategoria();

            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao15() {
            int ano;
            double preco;
            Console.WriteLine("15º) Num determinado Estado, para transferências de veículos, o DETRAN cobra uma taxa de\n 1 % para carros fabricados antes de 1990 e uma taxa de 1.5 % para os fabricados de 1990\n em diante, taxa esta incidindo sobre o valor de tabela do carro.O algoritmo abaixo lê o\n ano e o preço do carro e a seguir calcula e imprime imposto a ser pago.");
            Console.WriteLine();
            Console.WriteLine("Informe o Ano de fabricação do Veículo: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Preço do Veículo: ");
            preco = double.Parse(Console.ReadLine());

            CalculaTaxa taxa = new CalculaTaxa { };

            taxa.CalculaImposto(ano, preco);

            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao16() {
            string cargo; double salarioAntigo; double novoSalario; double diferencaDosSalarios; double bonus; double salarioBonus;
            Console.WriteLine("16º) Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo\n com o cargo, conforme a tabela abaixo.Faça um algoritmo que leia o salário e o cargo de\n um funcionário e calcule o novo salário.Se o cargo do funcionário não estiver na tabela,\n ele deverá, então, receber 40 % de aumento.Mostre o salário antigo, o novo salário e a\n diferença.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Código           Cargo           Percentual");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("101              Gerente         10%       ");
            Console.WriteLine("102              Engenheiro      20%       ");
            Console.WriteLine("103              Técnico         30%       ");
            Console.WriteLine("104              Outro           40%       ");
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("Informe o valor do seu salário atual: ");
            salarioAntigo = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Informe o seu cargo ou código: ");
            cargo = Convert.ToString(Console.ReadLine());

            if (cargo.ToLower() == "gerente" || cargo == "101" && salarioAntigo != 0 && salarioAntigo > 0) {
                novoSalario = (salarioAntigo * 0.1) + salarioAntigo;
                diferencaDosSalarios = novoSalario - salarioAntigo;
                Console.WriteLine("Salário antigo: R${0}", salarioAntigo);
                Console.WriteLine("Novo salário: R${0}", novoSalario);
                Console.WriteLine("Diferença: R${0}", diferencaDosSalarios);
                Console.WriteLine();

                Console.WriteLine("informe o bônus: ");
                bonus = Convert.ToDouble(Console.ReadLine());
                salarioBonus = novoSalario + bonus;
                Console.WriteLine("Seu novo salário com o bônus: {0}", salarioBonus);
            } else if (cargo.ToLower() == "engenheiro" || cargo == "102" && salarioAntigo != 0 && salarioAntigo > 0) {
                novoSalario = (salarioAntigo * 0.2) + salarioAntigo;
                diferencaDosSalarios = novoSalario - salarioAntigo;
                Console.WriteLine("Salário antigo: R${0}", salarioAntigo);
                Console.WriteLine("Novo salário: R${0}", novoSalario);
                Console.WriteLine("Diferença: R${0}", diferencaDosSalarios);
            } else if (cargo.ToLower() == "tecnico" || cargo.ToLower() == "técnico" || cargo == "103" && salarioAntigo != 0 && salarioAntigo > 0) {
                novoSalario = (salarioAntigo * 0.3) + salarioAntigo;
                diferencaDosSalarios = novoSalario - salarioAntigo;
                Console.WriteLine("Salário antigo: R${0}", salarioAntigo);
                Console.WriteLine("Novo salário: R${0}", novoSalario);
                Console.WriteLine("Diferença: R${0}", diferencaDosSalarios);
            } else if (cargo.ToLower() == "outro" || cargo == "104" && salarioAntigo != 0 && salarioAntigo > 0) {
                novoSalario = (salarioAntigo * 0.4) + salarioAntigo;
                diferencaDosSalarios = novoSalario - salarioAntigo;
                Console.WriteLine("Salário antigo: R${0}", salarioAntigo);
                Console.WriteLine("Novo salário: R${0}", novoSalario);
                Console.WriteLine("Diferença: R${0}", diferencaDosSalarios);
            } else {
                Console.WriteLine("Algo está incorreto! Tente novamente! ");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();

        }
        public static void Questao17() {
            double valorCreditoEspecial; double saldoMedio;
            Console.WriteLine("17º) Um banco concederá um crédito especial aos seus clientes, variável com o saldo médio no\n último ano.Faça um algoritmo que leia o saldo médio de um cliente e calcule o valor do\n crédito de acordo com a tabela abaixo. Mostre uma mensagem informando o saldo médio\n e o valor do crédito.");
            Console.WriteLine();
            Console.WriteLine("Crédito especial");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Informe o saldo médio no último ano: ");
            saldoMedio = Convert.ToDouble(Console.ReadLine());

            if (saldoMedio >= 0 && saldoMedio <= 200) {
                Console.WriteLine("Seu saldo médio é de: R${0}. Infelizmente você não tem direito ao crédito especial!", saldoMedio);
            } else if (saldoMedio >= 201 && saldoMedio <= 400) {
                valorCreditoEspecial = saldoMedio * 0.2;
                Console.WriteLine("Seu saldo é de: R${0} e o Valor do crédito especial é de: R${1}", saldoMedio, valorCreditoEspecial);
            } else if (saldoMedio >= 401 && saldoMedio <= 600) {
                valorCreditoEspecial = saldoMedio * 0.3;
                Console.WriteLine("Seu saldo é de: R${0} e o Valor do crédito especial é de: R${1}", saldoMedio, valorCreditoEspecial);
            } else if (saldoMedio >= 601) {
                valorCreditoEspecial = saldoMedio * 0.4;
                Console.WriteLine("Seu saldo é de: R${0} e o Valor do crédito especial é de: R${1}", saldoMedio, valorCreditoEspecial);
            } else {
                Console.WriteLine("Você precisa ter um saldo médio positivo no último ano! ");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao18() {
            int taxaInicialPlanoDeSaude = 100; int idadeDoConveniado; int precoAPagar;
            Console.WriteLine("18º) Criar um programa para identificar o valor a ser pago por um plano de saúde dada a idade\n do conveniado considerando que todos pagam R$ 100 mais um adicional conforme a\n seguinte tabela: 1) crianças com menos de 10 anos pagam R$80; 2) conveniados com idade\n entre 10 e 30 anos pagam R$50; 3) conveniados com idade entre 40 e 60 anos pagam\n R$95; e 4) conveniados com mais de 60 anos pagam R$130.");
            Console.WriteLine();
            Console.WriteLine("Orçamento plano de saúde");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Qual a sua idade: ");
            idadeDoConveniado = int.Parse(Console.ReadLine());

            if (idadeDoConveniado > 0 && idadeDoConveniado < 10) {
                precoAPagar = taxaInicialPlanoDeSaude + 80;
                Console.WriteLine("O valor do plano de saúde de acordo com sua idade é: R${0}", precoAPagar);
            } else if (idadeDoConveniado >= 10 && idadeDoConveniado <= 30) {
                precoAPagar = taxaInicialPlanoDeSaude + 50;
                Console.WriteLine("O valor do plano de saúde de acordo com sua idade é: R${0}", precoAPagar);
            } else if (idadeDoConveniado > 30 && idadeDoConveniado <= 60) {
                precoAPagar = taxaInicialPlanoDeSaude + 95;
                Console.WriteLine("O valor do plano de saúde de acordo com sua idade é: R${0}", precoAPagar);
            } else if (idadeDoConveniado > 60) {
                precoAPagar = taxaInicialPlanoDeSaude + 130;
                Console.WriteLine("O valor do plano de saúde de acordo com sua idade é: R${0}", precoAPagar);
            } else {
                Console.WriteLine("Sua idade não está inserida na nossa tabela de preço!");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();

        }
        public static void Questao19() {
            int codigoDoPedido; double valorAPagarDoItemPedido; int quantidadeDoItemPedido;
            Console.WriteLine("19º) O cardápio de uma lanchonete é o seguinte:/n Escrever um algoritmo que leia o código do item pedido, a quantidade e calcule o valor a\n ser pago por aquele lanche.Considere que a cada execução somente será calculado um\n item.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Código          Especificação          Preço Unitário ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("100             Cachorro quente        R$1,10");
            Console.WriteLine("101             Bauru simples          R$1,30");
            Console.WriteLine("102             Bauru c/ovo            R$1,50");
            Console.WriteLine("103             Hamburguer             R$1,10");
            Console.WriteLine("104             Cheeseburguer          R$1,30");
            Console.WriteLine("105             Refrigerante           R$1,00");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Informe o código do lanche: ");
            codigoDoPedido = int.Parse(Console.ReadLine());



            Console.WriteLine("Informe quantidade que deseja: ");
            quantidadeDoItemPedido = int.Parse(Console.ReadLine());


            switch (codigoDoPedido) {

                case 100:
                    valorAPagarDoItemPedido = quantidadeDoItemPedido * 1.10;
                    Console.WriteLine("O preço a ser pago é: R${0}!", valorAPagarDoItemPedido);
                    break;

                case 101:
                    valorAPagarDoItemPedido = quantidadeDoItemPedido * 1.30;
                    Console.WriteLine("O preço a ser pago é: R${0}!", valorAPagarDoItemPedido);
                    break;

                case 102:
                    valorAPagarDoItemPedido = quantidadeDoItemPedido * 1.50;
                    Console.WriteLine("O preço a ser pago é: R${0}!", valorAPagarDoItemPedido);
                    break;

                case 103:
                    valorAPagarDoItemPedido = quantidadeDoItemPedido * 1.10;
                    Console.WriteLine("O preço a ser pago é: R${0}!", valorAPagarDoItemPedido);
                    break;

                case 104:
                    valorAPagarDoItemPedido = quantidadeDoItemPedido * 1.30;
                    Console.WriteLine("O preço a ser pago é: R${0}!", valorAPagarDoItemPedido);
                    break;

                case 105:
                    valorAPagarDoItemPedido = quantidadeDoItemPedido * 1;
                    Console.WriteLine("O preço a ser pago é: R${0}!", valorAPagarDoItemPedido);
                    break;

                default:
                    Console.WriteLine("Código inserido está incorreto, tente novamente!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();



        }
        public static void Questao20() {
            int contador;
            int[] lista_de_numeros1 = new int[10];
            int[] lista_de_numeros2 = new int[10];// Nova Lista que Será Criada
            Console.WriteLine("20º) Crie um programa em c# que leia um vetor de 10 números inteiros e gere um segundo\n vetor(que deve ser impresso), cujas posições pares são o dobro do vetor original e as\n ímpares são o triplo.");
            Console.WriteLine();

            for (contador = 0; contador < 10; contador++) {
                Console.Write($"Digite o Número da Posição [{contador}]: ");
                lista_de_numeros1[contador] = int.Parse(Console.ReadLine());

            }
            for (contador = 0; contador < 10; contador++) {
                if (contador % 2 == 0) {
                    lista_de_numeros2[contador] = lista_de_numeros1[contador] * 2;
                } else {
                    lista_de_numeros2[contador] = lista_de_numeros1[contador] * 3;
                }
            }
            foreach (var inteiros in lista_de_numeros2) {
                Console.Write("|");
                Console.Write(inteiros + " ");
            }
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();

        }
        public static void Questao21() {
            int[,] Matriz1 = new int[3, 4];
            int[,] Matriz2 = new int[3, 4];
            int contador1, contador2, somador1, somador2;
            Console.WriteLine("24º) Faça um programa que leia uma matriz mat 3 x 4 de inteiros, substitua seus elementos\n negativos por 0 e imprima a matriz mat original e a modificada.");
            Console.WriteLine();
            contador1 = 0;
            contador2 = 0;
            somador2 = 1;

            while (contador1 < 3) {

                contador2 = 0;
                somador1 = 1;

                while (contador2 < 4) {
                    Console.Write("Preencha os valores que deseja na " + somador2 + "º linha da matriz, " + somador1 + "º número: ");
                    Matriz1[contador1, contador2] = int.Parse(Console.ReadLine());

                    contador2 = contador2 + 1; // É as posições do Array. Começa com Posição 0 e fica em loop até Ser  igual a 4.
                    somador1 = somador1 + 1;  // Quantidade de Números na Linha da Matriz.
                }

                contador1 = contador1 + 1; //É as Linhas da Matriz. Começa na posição 0 e fica em loop até ser igual a 3.
                somador2 = somador2 + 1; // Quantidade de Linhas da Matriz . só passa para a próxima linha quando termina o loop a cima.

            }

            contador1 = 0;
            contador2 = 0;

            while (contador1 < 3) {

                contador2 = 0;

                while (contador2 < 4) {
                    Matriz2[contador1, contador2] = Matriz1[contador1, contador2];

                    if (Matriz2[contador1, contador2] < 0) {
                        Matriz2[contador1, contador2] = 0;
                    }

                    contador2 = contador2 + 1;
                }

                contador1 = contador1 + 1;

            }


            Console.WriteLine();
            Console.WriteLine("Os dados informados pelo Usuário foram: ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|" + Matriz1[0, 0] + ", " + Matriz1[0, 1] + ", " + Matriz1[0, 2] + ", " + Matriz1[0, 3] + "|");
            Console.WriteLine("|" + Matriz1[1, 0] + ", " + Matriz1[1, 1] + ", " + Matriz1[1, 2] + ", " + Matriz1[1, 3] + "|");
            Console.WriteLine("|" + Matriz1[2, 0] + ", " + Matriz1[2, 1] + ", " + Matriz1[2, 2] + ", " + Matriz1[2, 3] + "|");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Os dados informados pelo Usuário que foram negativos, foram transformadas em 0: ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("|" + Matriz2[0, 0] + ", " + Matriz2[0, 1] + ", " + Matriz2[0, 2] + ", " + Matriz2[0, 3] + "|");
            Console.WriteLine("|" + Matriz2[1, 0] + ", " + Matriz2[1, 1] + ", " + Matriz2[1, 2] + ", " + Matriz2[1, 3] + "|");
            Console.WriteLine("|" + Matriz2[2, 0] + ", " + Matriz2[2, 1] + ", " + Matriz2[2, 2] + ", " + Matriz2[2, 3] + "|");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas quesões!");
            Console.ReadLine();
        }
        public static void Questao22() {
            double x, y, z;
            Console.WriteLine("35º) Escreva um programa para que o usuário entre com três valores X, Y, Z. O programa deve verificar  \nse esses valores podem ser os comprimentos dos lados de um triângulo e, se forem, informar o perímetro desse triângulo ao usuário. \nSe os valores não formarem um triângulo, escrever uma mensagem informando o usuário. Sendo que:\n" +
                               "A.Propriedade: o comprimento de cada lado de um triângulo é menor do que a soma dos comprimentos dos outros dois lados.\n" +
                               "B.Perímetro: é a soma dos três lados");
            Console.WriteLine();

            Console.WriteLine("Informe o Valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Valor de Y: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Valor de Z: ");
            z = double.Parse(Console.ReadLine());


            if (x + y > z && x + z > y && y + z > x) {
                Console.WriteLine("É um Triângulo!");
                Console.WriteLine($"Perimetro = {x + y + z}");
            } else {
                Console.WriteLine("Não É um Triângulo!");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 'ENTER' para seguir com próximas questões!");
            Console.ReadLine();
        }
    }
}

class DiferencaEntreNumeros {
    public int numero1 { get; set; }

    public int numero2 { get; set; }

    public int resultado { get; set; }

    public void CalculaDiferenca() {

        if (numero1 > numero2)
            resultado = numero1 - numero2;

        else
            resultado = numero2 - numero1;
    }
}

class AumentoSalario {
    public double salario { get; set; }

    public double calcula_Aumento { get; set; }

    public void CalculaAumentoSalario() {
        calcula_Aumento = salario * 0.3 + salario;
    }
}

class CategoriadeNadador {
    public int idade { get; set; }

    public void CalculaCategoria() {
        if (idade >= 5 && idade <= 7)
            Console.WriteLine("Categoria Infantil");

        else if (idade >= 8 && idade <= 10)
            Console.WriteLine("Categoria Juvenil");

        else if (idade >= 11 && idade <= 15)
            Console.WriteLine("Categoria Adolescente");

        else if (idade >= 16 && idade <= 30)
            Console.WriteLine("Categoria Adulto");

        else if (idade < 5)
            Console.WriteLine("Não Trabalhamos com Essa Categoria");

        else
            Console.WriteLine("Categoria Sênior");
    }
}

class CalculaTaxa {

    public void CalculaImposto(int ano, double preco) {
        if (ano < 1990)
            Console.WriteLine($"Imposto a ser Pago = {preco * 0.01}");

        else if (ano >= 1990)
            Console.WriteLine($"Imposto a Ser Pago = {preco * 0.015}");
    }
}



