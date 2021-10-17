import React from 'react'



const Contacts = ({ contacts }) => {

    return (

        <div>

            <center><h1>Contact List</h1></center>

            {contacts.map((contact) => (

                <div class="card">

                    <div class="card-body">

                        <h3 class="card-title">{contact.id}</h3>

                        <h5 class="card-title">{contact.nombre}</h5>

                        <h6 class="card-title">{contact.precio}</h6>


                        <p class="card-subtitle mb-2 text-muted">{contact.descripcion}</p>

                        

                    </div>

                </div>

            ))}

        </div>

    )

};



export default Contacts