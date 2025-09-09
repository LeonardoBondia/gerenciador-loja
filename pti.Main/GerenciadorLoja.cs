namespace PTI;
class GerenciadorLoja

    Celular[] celulares = new Celular[0];


    public void Novo(Celular celular)
    {
        Celular[] novo = new Celular[celulares.Length + 1];
        for (int i = 0; i < celulares.Length; i++) 
        {
            novo[i] = celulares[i];
        }
        novo[novo.Length - 1] = celular;

        celulares = novo;
    }


    public void Listar()
    {
        int cont = 1;
        foreach (Celular item in celulares) 
        {
            Console.WriteLine($"{cont++}. {item.Marca} (R$ {item.Preco}) - Estoque: {item.Estoque} {item.Cor} {item.Modelo}");
        }
    }

    public void Remover(int indice)
    {
        if (indice >= 0 && indice < celulares.Length)
        {
             Celular[] novo = new Celular[celulares.Length - 1];
        for (int i = 0, a = 0; i < celulares.Length; i++)
        {
            if (i != indice)
            {
                 novo[a++] = celulares[i];
            }
        }
         celulares = novo;
        }
    }
    public int EstoqueCelulares()
    {
         return celulares.Length;
    }
    public void EntradaEstoque(int indice, int quantidade)
    {
        if (indice >= 0 && indice < celulares.Length && quantidade > 0)
        {
            celulares[indice].Estoque += quantidade;
        }
    }

    public void SaidaEstoque(int indice, int quantidade)
    {
             if (indice >= 0 && indice < Celulares.Length && quantidade > 0)
             {
                celulares[indice].Estoque -= quantidade;
             }
    }

    public int VerificarEstoque(int indice)
    {
         if (indice >= 0 && indice < celulares.Length)
         {
            return celulares[indice].Estoque;
         }
          return 0;
    }
    
