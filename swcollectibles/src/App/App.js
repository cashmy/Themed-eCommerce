import React from 'react';
import CssBaseline from '@material-ui/core/CssBaseline';
//import MiniDrawer from './MiniDrawer/miniDrawer'
import AppBar from '../components/AppBar/AppBar.js'
import SignInSide from '../components/SignInSide/SignInSide.js'
import { BrowserRouter as Router } from 'react-router-dom'


const App = () => {


  return (
    <div >
      <Router> 
        <CssBaseline />
        <AppBar />
        <SignInSide />
        {/* <MiniDrawer /> */}
      </Router>
    </div>
  );
}

export default App;