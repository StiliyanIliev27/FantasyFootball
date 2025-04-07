// store/authSlice.js
import { createSlice } from '@reduxjs/toolkit';

// Initial state for authentication
const initialState = {
  user: null, // Store the user object
  token: null, // Store the authentication token
  isAuthenticated: false, // Track if the user is authenticated
};

// Create the slice
const authSlice = createSlice({
  name: 'auth',
  initialState,
  reducers: {
    // Action to set user data when the user logs in
    login(state, action) {
      console.log(state.user);
      state.user = action.payload.user;
      state.token = action.payload.token;
      state.isAuthenticated = true;
    },
    // Action to clear user data on logout
    logout(state) {
      state.user = null;
      state.token = null;
      state.isAuthenticated = false;
    },
    // Action to set user info (optional, in case you want to update the user)
    setUser(state, action) {
      state.user = action.payload;
    },
  },
});

// Export the actions to dispatch in components
export const { login, logout, setUser } = authSlice.actions;

// Export the reducer to use in the store
export default authSlice.reducer;
