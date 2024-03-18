string mesExtenso;

Console.WriteLine("---------   Mês por extenso   ---------\n");

Console.Write("Qual número correspondente ao mês?: ");
int mes = Convert.ToInt32(Console.ReadLine());

switch (mes)
{
    case 1:
        mesExtenso = "O 1º mês é Janeiro";
        break;

    case 2:
        mesExtenso = "O 2º mês é Fevereiro";
        break;

    case 3:
        mesExtenso = "O 3º mês é Março";
        break;

    case 4:
        mesExtenso = "O 4º mês é Abril";
        break;

    case 5:
        mesExtenso = "O 5º mês é Maio";
        break;

    case 6:
        mesExtenso = "O 6º mês é Junho";
        break;

    case 7:
        mesExtenso = "O 7º mês é Julho";
        break;

    case 8:
        mesExtenso = "O 8º mês é Agosto";
        break;

    case 9:
        mesExtenso = "O 9º mês é Setembro";
        break;

    case 10:
        mesExtenso = "O 10º mês é Outubro";
        break;

    case 11:
        mesExtenso = "O 11º mês é Novembro";
        break;

    case 12:
        mesExtenso = "O 12º mês é Dezembro";
        break;

    default:
        mesExtenso = "Mês inválido.";
        break;
}

Console.WriteLine();
Console.WriteLine(mesExtenso);