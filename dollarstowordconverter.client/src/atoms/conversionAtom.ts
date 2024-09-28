import { atom } from 'jotai';

interface State {
  convertedValue: string;
}

export const conversionAtom = atom<State>({
  convertedValue: 'No Conversion Yet'
});