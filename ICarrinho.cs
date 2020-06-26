namespace Aula26
{
    public interface ICarrinho
    {
        //Aqui criamos umaa interface para organizar o código, os métodos que serão utilizados
        //Na interface não se usa nem public e nem private
        //A interface nos obreiga a usar o Crud
         void Listar();
         void Cadastrar(Produto _produto);
         void Alterar(int _cod, Produto _produto);
         void Deletar(Produto _produto);
         void MostrarValor();
    }
}