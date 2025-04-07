import { configureStore } from '@reduxjs/toolkit';
import authReducer from './authSlice'; // Import the auth reducer

// Create the store and configure it with the authSlice
export const store = configureStore({
  reducer: {
    auth: authReducer, // Add the auth reducer to the store
  },
});
