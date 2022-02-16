import React, { useState } from 'react'
import { ClientPostI } from '../Interfaces/ClientPost.interface'
import axios from 'axios'
import Swal from 'sweetalert2';
import { ResponseInvoiceI } from '../Interfaces/responseRequest.interfaces';

export const UsePostForm = () => {
    
    const postInvoice = ( iDTO:ClientPostI)=>{        
        var axios = require('axios');
        var data = JSON.stringify({
        "date": new Date(),
        "customerId": Number(iDTO.customerId),
        "codes": iDTO.codes,
        "product": iDTO.product
        });

        var config = {
        method: 'post',
        url: 'http://localhost:5000/api/invoice',
        headers: { 
            'Content-Type': 'application/json'
        },
        data : data
        };

        axios(config).then( (response: { data: ResponseInvoiceI; } ) =>{ 
                 const responseData:ResponseInvoiceI = response.data
                
                 if(responseData.isError === false){
                     Swal.fire({
                         position: 'center',
                         icon: 'success',
                         title: `The invoice has been entered correctly`,
                         showConfirmButton: false,
                         width: '400px',
                         timer: 3000
                     })
                 }else{
                    Swal.fire({
                        position: 'center',
                        icon: 'error',
                        title: `The invoice cant be created`,
                        showConfirmButton: false,
                        width: '400px',
                        timer: 3000
                    })
                 }
             })


    }

    return postInvoice
}
