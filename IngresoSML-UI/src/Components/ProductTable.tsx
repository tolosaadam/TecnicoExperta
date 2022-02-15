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
import { useEffect, useState } from 'react';
import { FieldProps } from 'formik';



// const rows:ProductI[] = [

// ]
export default function BasicTable({codeNames}:ProductTableI) {

  const [rows2, setRows] = useState([
    {
      codeName: "",
    }
  ]);

  const deleteItem = (row:any)=>{

    const newState = [...codeNames]
    const index = codeNames.indexOf(row)
    codeNames.splice(index,1)
    setRows(newState)
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
            {codeNames.length !== 0
            ? 
            codeNames.map((code) => (
              <TableRow
                key={code.codeName}
                sx={{ '&:last-child td, &:last-child th': { border: 0 } }}
              >
                <TableCell component="th" align="center" scope="row">
                  {code.codeName}
                </TableCell>
                <TableCell align="center">
                  <Button variant="text" id="codes" onClick={ ()=> deleteItem(code) }>Delete</Button>
                </TableCell>
              </TableRow>
              
            ))
            :
            <TableRow sx={{ '&:last-child td, &:last-child th': { border: 0 } }}>
                <TableCell component="th" scope="row" sx={{ m:2 , fontSize:18, color:'GrayText' }} >
                No data 
              </TableCell>
            </TableRow>
          }
          </TableBody>
        </Table>
      </TableContainer>
    );
  }