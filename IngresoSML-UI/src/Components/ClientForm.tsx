import { Field, Form, Formik, FormikHelpers } from 'formik';
import React from 'react'
import { ClientPostI } from '../Interfaces/ClientPost.interface';
import ProductTable from './ProductTable';

export const ClientForm = () => {
  return (
    <div>
      <h1>Signup</h1>
      <Formik
        initialValues={{
          client: [{id:0, name:''}],
          products:[{code:''}]
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
            {}
          </Field>

          <button type="submit">Submit</button>
        </Form>
      </Formik>
      <ProductTable/>
    </div>
  )
}
