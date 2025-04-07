import axios from "axios";

const API_HOST = "free-api-live-football-data.p.rapidapi.com";
const API_KEY = process.env.NEXT_PUBLIC_RAPIDAPI_KEY;

const api = axios.create({
  baseURL: `https://${API_HOST}`,
  headers: {
    "x-rapidapi-host": API_HOST,
    "x-rapidapi-key": API_KEY,
  },
});

export const getLiveMatches = async () =>{
  try{
    const response = await api.get("/football-current-live");
    return response.data.response.live;
  }catch(error){
    console.error("Failed to fetch leagues:", error.message);
    throw error;
  }
}

export const getTeamLogo = async (teamId) => {
  try {
    const response = await api.get("/football-team-logo", {
      params: { teamid: teamId },
    });
    return response.url;
  } catch (error) {
    console.error(`Failed to fetch logo for team ${teamId}:`, error.message);
    throw error;
  }
};