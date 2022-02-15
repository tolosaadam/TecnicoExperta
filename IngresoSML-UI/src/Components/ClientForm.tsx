import { Button } from '@mui/material';
import { Field, Form, Formik, FormikHelpers } from 'formik';
import React, { useEffect, useState } from 'react'
import { UseCustomer } from '../Hooks/UseCustomer';
import { ClientPostI } from '../Interfaces/ClientPost.interface';
import { ProductI, ProductTableI } from '../Interfaces/Product.Interface';
import ProductTable from './ProductTable';
import './clientForm.css';
import { UsePostForm } from '../Hooks/UsePostForm';
import Swal from 'sweetalert2';

export const ClientForm = () => {

  const {GetCustomers, customers} = UseCustomer() 
  const postInvoice =  UsePostForm()

  const [products, setProducts] = useState<ProductI[]>([])

  useEffect(() => {
    GetCustomers()     
  }, [])

  const addProduct = ( product:any ) =>{
    let flag = false

    products.forEach(function (value) {
      if(value.codeName === product){
        flag = true
      }
    }); 


    if(flag === false){

      products.push({codeName: product}) 
      setProducts( products );

    }else{

      Swal.fire({
        position: 'center',
        icon: 'error',
        title: "The code has already exist",
        showConfirmButton: false,
        width: '400px',
        timer: 3000
    })
    }
  }

  
  return (
    <div className='container-form'>
      <section className='title' >
        <h1>Invoices</h1>
      </section >
      <Formik
        initialValues={{
          customerId: 0,
          codes:[''],
          product:''
        }}
        onSubmit={(
          values: ClientPostI,
          { setSubmitting }: FormikHelpers<ClientPostI>
        ) => {

          alert(JSON.stringify(values,null,2))
          postInvoice(values)
          setSubmitting( false )
        }}
      >
        {
          ({ setFieldValue, values })=>(
            <Form style={{ display:'flex', flexDirection:'column', justifyContent:'center'}}>
              <label htmlFor="client">Client</label>
              <Field as="select" id="customerId" name="customerId" style={{ width:565, padding:7  }}>
                {customers.map(customer => (
                <option value={customer.customerId} key={customer.customerId}>{customer.firstName} {customer.lastName}</option> 
                ))}
              </Field>
              <label htmlFor="product" style={{ marginTop:10}}>Product code</label>
              <section style={{ display:'flex', flexDirection:'row'}}>
                <Field name="product" placeholder="Agregar un producto" className="input"/>
                <Button variant="outlined" sx={{ ml:2}} onClick={ ()=>{ 
                                        addProduct( values.product )
                                        setFieldValue('product', '')
                                        setFieldValue('codes',  products)
                                        }}> Add </Button>
              </section>
              
              <Field component={ProductTable} name="codes" codeNames={products} />

               <Button variant="outlined" type='submit'  style={{ width:600, marginTop:20}}> Send </Button>

          </Form>
          )
        }
        
      </Formik>
    </div>
  )
}
