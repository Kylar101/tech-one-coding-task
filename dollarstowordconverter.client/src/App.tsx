import './App.css'
import { Box, Container, Typography } from '@mui/material'
import { Form } from './components/Form'
import { useAtom } from 'jotai'
import { conversionAtom } from './atoms/conversionAtom'

function App() {
    const [conversion] = useAtom(conversionAtom);
    return (
        <Container maxWidth="sm">
            <Box sx={{ my: 4 }}>
                <Typography variant="h4" component="h1" sx={{ mb: 4 }}>
                    Enter a dollar amount in numbers to convert it to words:
                </Typography>
            </Box>
            <Box sx={{ my: 4 }}>
                <Form />
            </Box>

            <Box sx={{ my: 4 }}>
                {conversion.convertedValue}
            </Box>
        </Container>
  )
}

export default App
