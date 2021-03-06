import React, { useState } from 'react'
import { ClientGetI } from '../Interfaces/ClientGet.interface'
import axios from 'axios'

export const UseCustomer = () => {
    const [customers, setCustomers] = useState<ClientGetI[]>([{customerId:0, firstName:'', lastName:''}])

    const GetCustomers = () => {
        axios.get('http://localhost:5000/api/customer')
        .then(response => {
            setCustomers(response.data)
        })
    }
    return {GetCustomers, customers}
}
