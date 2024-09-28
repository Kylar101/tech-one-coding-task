import { Alert, Button, Grid2 as Grid } from '@mui/material';
import { FC, useState } from 'react';
import { RegisterOptions, useForm } from 'react-hook-form';
import { TextControl } from './FormControls/TextControl';
import { apiClient } from './clients/apiClient';
import { useAtom } from 'jotai';
import { conversionAtom } from '../atoms/conversionAtom';

type FormValues = {
  value: string
}

const converterRules: RegisterOptions = {
  required: true,
  valueAsNumber: true,
  pattern: {
    value: /^(0|[1-9]\d*)(\.\d+)?$/i,
    message: 'Please enter a valid number'
 },
}

export const Form: FC = () => {
  // eslint-disable-next-line @typescript-eslint/no-unused-vars
  const [_, setConversion] = useAtom(conversionAtom);
  const [isConverting, setIsConverting] = useState(false);
  const [hasError, setHasError] = useState(false);
  const { control, handleSubmit } = useForm<FormValues>();
  const onSubmit = handleSubmit(async ({ value }) => {
    setIsConverting(true);
    setHasError(false);
    try {
      const request  = await apiClient.post('http://localhost:5260/Converter', {
        value
      });
      setConversion({ convertedValue: request.data });
    } catch (err) {
      console.log('unable to convert to words', err);
      setHasError(true);
    } finally {
      setIsConverting(false);
    }
  });
  return (
    <form onSubmit={onSubmit}>
      {hasError &&
        <Alert severity='error'>
          Unable to convert number to words, please try again
        </Alert>
      }
      <Grid container spacing={2}>
        <Grid size={8}>
          <TextControl
            control={control}
            label='Dollars ($) in Numbers'
            name='value'
            disabled={isConverting}
            rules={converterRules}
          />
        </Grid>
        <Grid size={4}>
          <Button
            variant='contained'
            type='submit'
            disabled={isConverting}
          >
            Convert
          </Button>
        </Grid>
      </Grid>
    </form>
  )
}