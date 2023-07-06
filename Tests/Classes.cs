namespace Tests;
public class FornecedorTests
{
    public int ID { get; private set; }
    public string Nome { get; private set; }
    public string NomeSocial { get; private set; }
    public string Endereco { get; private set; }
    public string Telefone { get; private set; }   
    public string CNPJ { get; private set; }

    public FornecedorTests(int id, string nome, string nomeSocial, string endereco, string telefone, string cnpj)
    {
        ID = id;
        Nome = nome;
        NomeSocial = nomeSocial;
        Endereco = endereco;
        Telefone = telefone;
        CNPJ = cnpj;
    }
}
public class ProdutoTests
{
    public int ID { get; private set; }
    public string ModeloID { get; private set; }
    public string CategoriaID { get; private set; }

    public ProdutoTests(int id, string modeloID, string categoriaID)
    {
        ID = id;
        ModeloID = modeloID;
        CategoriaID = categoriaID;
    }
}
public class EstoqueTests
{
    public int ID { get; private set; }
    public string Nome { get; private set; }
    public string Endereco { get; private set; }

    public EstoqueTests(int id, string nome, string endereco)
    {
        ID = id;
        Nome = nome;
        Endereco = endereco;
    }
}
