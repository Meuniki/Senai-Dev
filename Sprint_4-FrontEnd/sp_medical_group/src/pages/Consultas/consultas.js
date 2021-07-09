import {Component } from 'react';

class Consultas extends React.Component{
    constructor(props){
        super(props);
        this.state = {
            ListaConsultas : [],
            Paciente : ' SQL '
        }
    }
    componentDidMount(){

    }

    render(){
        return(
            <div>
                <main>
                    <section>
                        <h2> Lista de tipos eventos</h2>
                        <table>
                            <thead>
                                <th>#</th>
                                <th>Conteudo</th>
                            </thead>
                        </table>
                    </section>
                </main>
            </div>
        );
    }
}