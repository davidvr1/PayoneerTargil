import { useState } from 'react'
import './App.css'
import axios from 'axios'

function App() {
  const [id, setId] = useState<string>('')
  const [amount, setAmount] = useState<number | null>(null)
  const [period, setPeriod] = useState<number | null>(null)
  const [loanValue,setLoanValue]=useState<number | null>(null)
   


  const handleSubmit = async (event: React.FormEvent<HTMLFormElement>) => {
    event.preventDefault();
    
    try {
      // Assuming your API endpoint is '/calculateAmount'
      const response = await axios.post('http://localhost:5270/LoabWebApi', {
        id,
        amount,
        period,
      });
      
      setLoanValue(response.data);
    } catch (error) {
      console.error('Error fetching data:', error);
      // Handle error, e.g., show an error message to the user
    }
  };

  return (
    <>    
      <h1>Loan Calc</h1>
      <form onSubmit={handleSubmit}>
      <div>
        <label>ID:</label>
        <input min="0" value="0" step="1"
        type='number'
        value={id} 
        onChange={(e)=>{setId(e.target.value) }}
        required
        />
      </div>
      <div>
        <label>Amount:</label>
        <input type='number' min="0"  step=".01"
         value={amount}
         onChange={(e)=> setAmount(parseFloat(e.target.value))}
         required
         />
      </div>
      <div>
        <label>Loan Period:</label>
        <input type='number' min="0"  step="1"
         value={period}
         onChange={(e)=> setPeriod(parseFloat(e.target.value))}
         required
         />
      </div>
      <div className="card">
        <button type="submit">Calculate</button>        
      </div>
      </form>    
      {loanValue !== null && <div>
        <h3>Loan will cost: <span>{loanValue} nis </span></h3>
        </div> }
    </>
  )
}

export default App
