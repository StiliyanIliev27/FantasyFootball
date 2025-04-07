process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';

import { axiosInstance } from "@/utils/api";

export const getLeagues = async () => {
  try {
    const response = await axiosInstance.get("/Football/leagues");
    return response.data.result;
  } catch (error) {
    console.error("Error fetching leagues:", error);
    return [];
  }
};
