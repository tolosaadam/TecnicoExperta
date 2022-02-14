import { Field, Form, Formik, FormikHelpers } from 'formik';
import React, { useEffect, useState } from 'react'
import { UseCustomer } from '../Hooks/UseCustomer';
import { ClientPostI } from '../Interfaces/ClientPost.interface';
import { ProductI, ProductTableI } from '../Interfaces/Product.Interface';
import ProductTable from './ProductTable';

export const ClientForm = () => {
  const {GetCustomers, customers} = UseCustomer() 

  const [products, setProducts] = useState<ProductI[]>([{product:''}])

  useEffect(() => {
    GetCustomers()     
  }, [])

  
  return (
    <div>
      <h1>Signup</h1>
      <Formik
        initialValues={{
          client: [{id:0, name:''}],
          products:[{product:''}]
        }}
        onSubmit={(
          values: ClientPostI,
          { setSubmitting }: FormikHelpers<ClientPostI>
        ) => {
          setTimeout(() => {
            alert(JSON.stringify(values, null, 2));
            setSubmitting(false);
          }, 500);
        }}
      >
        <Form>
          <label htmlFor="client">Client</label>
          <Field className='w-full' as="select" id="client" name="client">
            {customers.map(customer => (
             <option value={customer.customerId} key={customer.customerId}>{customer.firstName} {customer.lastName}</option> 
            ))}
          </Field>

          <button type="submit">Submit</button>
        </Form>
      </Formik>
      <ProductTable products={products} />
    </div>
  )
}
