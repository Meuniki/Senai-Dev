import { Component } from "react"


class Catalogo extends Component{
    constructor(props){
        super(props);
        this.state = {
            ListaLivros : [],
            titulo : ''
        }
    }

    buscarLivros = () => {
        console.log('Qualquer coisa')

        fetch("http://localhost:5000/api/Livros")

        .then(resposta => resposta.json())

        .then(data => this.setState({ ListaLivros : data}))

        .catch( (erro) => console.log(erro))
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
                </main>
            </div>
        )
    }
}

export default Catalogo;