import React from 'react'
import { FormControl, FormHelperText, InputLabel, MenuItem, Select as MuiSelect} from '@material-ui/core'
import { makeStyles } from '@material-ui/core/styles';

const useStyles = makeStyles((theme) => ({
    formControl: {
        margin: theme.spacing(1),
        minWidth: 400,
    }
}))

const Select = (props) => {
    const { name, label, value, error=null, onChange, options } = props
    const classes = useStyles()

    return (
        <FormControl variant='outlined' className={classes.FormControl}
        {...(error && {error:true})}
        >
            <InputLabel>{label}</InputLabel>
            <MuiSelect
                label={label}
                name={name}
                value={value}
                onChange={onChange}
                fullWidth
            >
                <MenuItem value="">None</MenuItem>
                {
                    options.map(
                        item =>(<MenuItem key={item.id} value={item.id}>{item.title}</MenuItem>)
                     )
                }
            </MuiSelect>
            {error && <FormHelperText>{error}</FormHelperText>}
        </FormControl>
    )
}

export default Select