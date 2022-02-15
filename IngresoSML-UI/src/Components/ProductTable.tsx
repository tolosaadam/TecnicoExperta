import * as React from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import { ProductI, ProductTableI } from '../Interfaces/Product.Interface';
import { Button, TextField, Typography } from '@mui/material';
import { useState } from 'react';
import { FieldProps } from 'formik';



// const rows:ProductI[] = [

// ]
export default function BasicTable({products, field}:ProductTableI & FieldProps) {
    // const [products, setProducts] = useState<ProductI[]>([{code:''}]);

    const deleteItem = (product:ProductI)=>{

      // console.log(product);
      const index = products.indexOf(product)

      if (index > -1) {
        products.splice(index, 1);
      }
    }

    return (
      <TableContainer sx={{ mt:10}}>
        <Table sx={{ maxWidth: 700 }} aria-label="Product Table">
          <TableHead>
            <TableRow>
              <TableCell align="center">Code</TableCell>
              <TableCell align="center">Action</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {products.length === 0 
            ? 
              <Typography sx={{ m:2 , fontSize:18, color:'GrayText' }} >
                No data 
            </Typography>
            :
            products.map((product) => (
              <TableRow
                key={product.product}
                sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
                {...field}
              >
                <TableCell component="th" align="center" scope="row">
                  {product.product}
                </TableCell>
                <TableCell align="center">
                  <Button variant="text" onClick={ ()=> deleteItem( product) }>Delete</Button>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    );
  }