# 📱 Loja de Celulares – Sistema em C#

Projeto desenvolvido em **C# (.NET 8.0)** como parte de estudos práticos.  
O sistema simula uma **loja de celulares**, permitindo cadastrar, listar, remover e gerenciar o estoque de produtos.

---

## 🚀 Funcionalidades
- **Cadastro de novos celulares** (marca, modelo, cor, preço e estoque inicial).
- **Listagem** de todos os celulares cadastrados.
- **Remoção** de celulares do estoque.
- **Entrada de estoque** (adicionar unidades a um celular existente).
- **Saída de estoque** (venda/retirada de unidades).
- **Validações** para evitar remoções/saídas inválidas.

---

## 📖 Tecnologias

Linguagem: C#

Framework: .NET 8.0

pti.Main.csproj.nuget.dgspec

project.assets

## 🛠️ Estrutura do Projeto
- `Program.cs` → Ponto de entrada com menu principal e interação com o usuário:contentReference[oaicite:0]{index=0}  
- `Produtos.cs` → Classe base com atributos de um celular (Marca, Modelo, Cor, Preço e Estoque):contentReference[oaicite:1]{index=1}  
- `GerenciadorLoja.cs` → Classe responsável por gerenciar a lista de celulares e operações de estoque:contentReference[oaicite:2]{index=2}

---

## 📂 Exemplo de uso
Ao executar o programa, o menu principal é exibido:

## -- Loja de celulares --

 1.Novo
 
 2.Listar
 
 3.Remover
 
 4.Entrada Estoque
 
 5.Saída Estoque
 
 6.Sair


### Fluxo típico:
1. Adicionar um novo celular → informar marca, preço, modelo e cor.  
2. Listar celulares cadastrados.  
3. Realizar entrada ou saída de estoque.  

---

## 🖥️ Como executar
### Pré-requisitos
- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

### Passos
```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/seu-repo.git

# Acessar a pasta do projeto
cd pti.Main

# Restaurar dependências (se houver)
dotnet restore

# Compilar e executar
dotnet run



--Projeto feito para fins acadêmicos--
