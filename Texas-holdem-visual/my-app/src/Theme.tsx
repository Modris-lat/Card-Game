import { createMuiTheme } from "@material-ui/core";
import { ThemedStyledProps} from "styled-components";
import { borders } from "./constants/Borders";
import {Theme as MuiTheme} from '@material-ui/core'

export function getTheme<P>(action: (theme: MuiTheme, props?: ThemedStyledProps<P, MuiTheme>) => any) {
    return (props: ThemedStyledProps<P, MuiTheme>) => {return action(props.theme, props)};
}
export const Theme = createMuiTheme({
    shape: {
        borderRadius: borders.globalBorderRadius
    },
    spacing: (factor: number) => `${0.625 * factor} rem`,
    overrides: {
        MuiCardContent: {
            root: borders
        }
    }
})