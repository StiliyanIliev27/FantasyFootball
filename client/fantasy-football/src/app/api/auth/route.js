import { axiosInstance } from '@/utils/api';

export const signIn = async (email, password) => {
  try {
    const response = await axiosInstance.post('/Auth/sign-in', { email, password });
    return response.data; // Return data on success
  } catch (error) {
    // If the error response exists, return it
    if (error.response) {
      return { error: error.response.data.errorMessage }; // Return the error message from the backend
    } else {
      return { error: 'An unexpected error occurred. Please try again.' }; // Default error message
    }
  }
};
