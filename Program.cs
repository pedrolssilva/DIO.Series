using System;

namespace DIO.Series
{
  class Program
  {
    static RepositorySerie repository = new RepositorySerie();
    static void Main(string[] args)
    {
      string userOption = GetUserOption();

			while (userOption.ToUpper() != "X")
			{
				switch (userOption)
				{
					case "1":
						ListSeries();
						break;
					case "2":
						InsertSerie();
						break;
					case "3":
						UpdateSerie();
						break;
					case "4":
						DeleteSerie();
						break;
					case "5":
						ViewSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				userOption = GetUserOption();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
    }
    
    private static void DeleteSerie()
		{
			Console.Write("Digite o id da série: ");
			int serieIndex = int.Parse(Console.ReadLine());

			repository.Delete(serieIndex);
		}

    private static void ViewSerie()
		{
			Console.Write("Digite o id da série: ");
			int serieIndex = int.Parse(Console.ReadLine());

			var serie = repository.ReturnById(serieIndex);

			Console.WriteLine(serie);
		}

    private static void UpdateSerie()
		{
			Console.Write("Digite o id da série: ");
			int serieIndex = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int genderInput = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string titleInput = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int yearInput = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string descriptionInput = Console.ReadLine();

			Serie updateSerie = new Serie(id: serieIndex,
										gender: (Gender)genderInput,
										title: titleInput,
										year: yearInput,
										description: descriptionInput);

			repository.Update(serieIndex, updateSerie);
		}
    private static void ListSeries()
		{
			Console.WriteLine("Listar séries");
			var list = repository.List();

			if (list.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in list)
			{
                var deleted = serie.GetDeleted();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.getId(), serie.GetTitle(), (deleted ? "*Excluído*" : ""));
			}
		}

    private static void InsertSerie()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int genderInput = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string titleInput = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int yearInput = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string descriptionInput = Console.ReadLine();

			Serie newSerie = new Serie(id: repository.NextId(),
										gender: (Gender)genderInput,
										title: titleInput,
										year: yearInput,
										description: descriptionInput);

			repository.Insert(newSerie);
		}

    private static string GetUserOption()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Séries a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string userOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userOption;
		}
  }
}
