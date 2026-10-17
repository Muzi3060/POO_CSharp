namespace Ex007;

public class ControleRemoto
{
    public short Canal { get; set; } = 1;
    public short Volume { get; set; } = 2;
    public bool ligado { get; set; } = false;

    public ControleRemoto()
    {
        menu();
    }
    
    public void LigarDesligar()
    {
        ligado = !ligado;
    }
    
    public void ProximoCanal()
    {
        if (ligado)
        {
            if (Canal >= 5) {
                Canal = 1;
            } else { Canal++;
            }
        }
    }
    
    public void CanalAnterior()
    {
        if (ligado)
        {
            if (Canal <= 1) {
                Canal = 5;
            } else { Canal--;
            }
        }
    }
    
    public void AumentarVolume()
    {
        if (ligado)
        {
            if (Volume >= 5) {
                Volume = 5;
            } else { Volume++;
            }
        }
    }

    public void DiminuirVolume()
    {
        if (ligado)
        {
            if (Volume <= 1) {
                Volume = 1;
            }else {
                Volume--;
            }
        }
    }

    public void menu()
    {

        while (true)
        {

            if (!ligado)
            {
                Console.WriteLine("\u001b[31m" + "A TV está desligada" + "\u001b[0m");
                Console.WriteLine("< CH1 > - VOL2 + ");
            }
            else
            {
                Console.WriteLine("CANAL = " + Canal);
                Console.WriteLine("VOLUME = " + Volume);
                Console.WriteLine("< CH1 > - VOL2 + ");
                
            }
            
            LogicaControle();

        }
    }

    public void LogicaControle()
    {
        switch (Console.ReadLine())
        {
            case "@":
                Console.Clear();
                LigarDesligar();
                break;
            case "+":
                Console.Clear();
                AumentarVolume();
                break;
            case "-":
                Console.Clear();
                DiminuirVolume();
                break;
            case "<":
                Console.Clear();
                CanalAnterior();
                break;
            case ">":
                Console.Clear();
                ProximoCanal();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção inválida");
                break;
        }
    }

}