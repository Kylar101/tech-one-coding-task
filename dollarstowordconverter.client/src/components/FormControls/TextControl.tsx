import { TextField } from '@mui/material';
import { FC } from 'react';
import { Control, Controller, RegisterOptions } from 'react-hook-form';

interface FormInputTextProps {
  name: string;
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  control: Control<any>;
  rules?: RegisterOptions;
  label: string;
  disabled?: boolean;
  defaultValue?: string;
}

export const TextControl: FC<FormInputTextProps> = ({
  name,
  control,
  label,
  rules,
  disabled,
}) => {
  return (
    <Controller
      name={name}
      control={control}
      rules={rules}
      disabled={disabled}
      render={({
        field: { onChange, value, disabled },
        fieldState: { error },
      }) => (
        <TextField
          disabled={disabled}
          helperText={error ? error.message : null}
          size="small"
          error={!!error}
          onChange={onChange}
          value={value}
          fullWidth
          label={label}
        />
      )}
    />
  );
};