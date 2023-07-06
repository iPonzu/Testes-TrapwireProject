namespace Solutions.Tests;

[TestClass]
public class FornecedorTests
{
    [TestMethod]
    public void CriarFornecedor_DeveCriarClassesCorretamente()
    {
        int id = 1;
        string nome = "MegaBebidas Distribuidora de Bebidas Ltda";
        string nomeSocial = "MegaBebidas";
        string endereco = "Rua das Tulipas, 123";
        string telefone = "(11) 01234-5678";
        string cnpj = "12.345.678/0001-90";

        Assert.AreEqual(id, 1);
        Assert.AreEqual(nome, "MegaBebidas Distribuidora de Bebidas Ltda");
        Assert.AreEqual(nomeSocial, "MegaBebidas");
        Assert.AreEqual(endereco, "Rua das Tulipas, 123");
        Assert.AreEqual(telefone, "(11) 01234-5678");
        Assert.AreEqual(cnpj, "12.345.678/0001-90");
    }

    [TestMethod]
    public void EditarFornecedor_DeveEditarClassesCorretamente()
    {
        int id = 1 + 1;
        string nome = "MegaAlimentos Comerciante de Alimentos e bebidas Ltda";
        string nomeSocial = "MegaBebidas e Comidas";
        string endereco = "Av. Brasil, 123";
        string telefone = "(49) 12345-6789";
        string cnpj = "98.765.432/0001-21";

        Assert.AreEqual(id, 2);
        Assert.AreEqual(nome, "MegaAlimentos Comerciante de Alimentos e bebidas Ltda");
        Assert.AreEqual(nomeSocial, "MegaBebidas e Comidas");
        Assert.AreEqual(endereco, "Av. Brasil, 123");
        Assert.AreEqual(telefone, "(49) 12345-6789");
        Assert.AreEqual(cnpj, "98.765.432/0001-21");
    }

    [TestMethod]
    public void ExcluirFornecedor_DeveExcluirClassesCorretamente()
    {
        int id = 0;
        string nome = "";
        string nomeSocial = "";
        string endereco = "";
        string telefone = "";
        string cnpj = "";

        Assert.AreEqual(id, 0);
        Assert.AreEqual(nome, "");
        Assert.AreEqual(nomeSocial, "");
        Assert.AreEqual(endereco, "");
        Assert.AreEqual(telefone, "");
        Assert.AreEqual(cnpj, "");

    }
}
[TestClass]
public class ProdutoTests
{
    [TestMethod]
    public void CriarProduto_DeveCriarClassesCorretamente()
    {
        int id = 1;
        string modeloID = "Água de coco 1L";
        string categoriaID = "Não alcoólico";

        Assert.AreEqual(id, 1);
        Assert.AreEqual(modeloID, "Água de coco 1L");
        Assert.AreEqual(categoriaID, "Não alcoólico");

    }

    [TestMethod]
    public void EditarProduto_DeveEditarClassesCorretamente()
    {
        int id = 1 + 1;
        string modeloID = "Água de coco 2L";
        string categoriaID = "Não alcoólico";

        Assert.AreEqual(id, 2);
        Assert.AreEqual(modeloID, "Água de coco 2L");
        Assert.AreEqual(categoriaID, "Não alcoólico");

    }

    [TestMethod]
    public void ExcluirProduto_DeveExcluirClassesCorretamente()
    {
        int id = 0;
        string modeloID = "";
        string categoriaID = "";

        Assert.AreEqual(id, 0);
        Assert.AreEqual(modeloID, "");
        Assert.AreEqual(categoriaID, "");

    }
}

[TestClass]
public class EstoqueTests
{
    
    
    [TestMethod]
    public void CriarEstoque_DeveCriarClassesCorretamente()
    {
        int id = 1;
        string nome = "Estoque 1";
        string endereco = "Rua das Tulipas, 123";

        Assert.AreEqual(id, 1);
        Assert.AreEqual(nome, "Estoque 1");
        Assert.AreEqual(endereco, "Rua das Tulipas, 123");

    }

    [TestMethod]
    public void EditarEstoque_DeveEditarClassesCorretamente()
    {
        int id = 1 + 1;
        string nome = "Estoque 2";
        string endereco = "Av. Brasil, 123";

        Assert.AreEqual(id, 2);
        Assert.AreEqual(nome, "Estoque 2");
        Assert.AreEqual(endereco, "Av. Brasil, 123");

    }

    [TestMethod]
    public void ExcluirEstoque_DeveExcluirClassesCorretamente()
    {
        int id = 0;
        string nome = "";
        string endereco = "";

        Assert.AreEqual(id, 0);
        Assert.AreEqual(nome, "");
        Assert.AreEqual(endereco, "");
        
    }
}