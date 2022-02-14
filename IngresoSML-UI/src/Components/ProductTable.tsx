import * as React from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import { ProductI, ProductTableI } from '../Interfaces/Product.Interface';
import { Button } from '@mui/material';
import { useState } from 'react';



// const rows:ProductI[] = [

// ]
export default function BasicTable({products}:ProductTableI) {
    // const [products, setProducts] = useState<ProductI[]>([{code:''}]);
    return (
      <TableContainer component={Paper}>
        <Table sx={{ minWidth: 650 }} aria-label="Product Table">
          <TableHead>
            <TableRow>
              <TableCell align="right">Code</TableCell>
              <TableCell align="right">Action</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {products.map((product) => (
              <TableRow
                key={product.product}
                sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
              >
                <TableCell component="th" scope="row">
                  {product.product}
                </TableCell>
                <TableCell  align="right"><Button variant="text">Delete</Button></TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    );
  }