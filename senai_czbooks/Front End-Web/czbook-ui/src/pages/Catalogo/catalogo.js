import { Component } from "react"


class Catalogo extends Component{
    constructor(props){
        super(props);
        this.state = {
            ListaLivros : [],
            idCategoria : 0,
            idLivraria : 0,
            idAutor : 0,
            titulo : '',
            sinopse : '',
            dataPublicacao : '0000/00/00',
            preco : 0.0

        }
    }

    buscarLivros = () => {
        console.log('Qualquer coisa')

        fetch("http://localhost:5000/api/Livros")

        .then(resposta => resposta.json())

        .then(data => this.setState({ ListaLivros : data}))

        .catch( (erro) => console.log(erro))
    }

    atualizaEstadoTitulo = async (event) => {
        await this.setState({ titulo: event.target.value })
    };
    
    cadastraLivro = (event) => {
        event.preventDefault();
    }

    componentDidMount(){
        this.buscarLivros();
    }

    render(){
        return(
            <div>
                <main>
                    <section>
                        {/* Lista de Livros */}
                        <h2>Lista de Livros</h2>
                        <table>
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Livros</th>
                                </tr>
                            </thead>
                                
                            <tbody>
                                {
                                    this.state.ListaLivros.map( (Livro) => {
                                        return (
                                            <tr>
                                                <td>{Livro.idLivro}</td>
                                                <td>{Livro.idCategoria}</td>
                                                <td>{Livro.idLivraria}</td>
                                                <td>{Livro.idAutor}</td>
                                                <td>{Livro.titulo}</td>
                                                <td>{Livro.sinopse}</td>
                                                <td>{Livro.dataPublicacao}</td>
                                                <td>{Livro.preco}</td>
                                            </tr>
                                        )
                                    } )
                                }
                            </tbody>
                        </table>
                    </section>
                    <section>
                        {/* Cadastro de Livro */}
                        <h2>Cadastro de Livro</h2>
                        <form onSubmit={this.cadastrarLivro}>
                            <div>
                                <input 
                                    type = "text"
                                    value = {this.state.titulo}
                                    onChange = {this.atualizaEstadoTitulo}
                                    placeholder = "Título do livro"
                                />
                                <button type="submit">Cadastrar</button>
                            </div>
                        </form>
                    </section>
                </main>
            </div>
        )
    }
}

export default Catalogo;