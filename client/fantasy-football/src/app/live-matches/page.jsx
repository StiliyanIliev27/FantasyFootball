import { getLiveMatches } from "../api/football-api";
import MatchTable from "../components/live-matches/MatchTable";

export default async function LiveMatches() {
  const data = await getLiveMatches();

  return (
    <main>
      <h1 style={{ textAlign: "center", color: "#fff", marginTop: "2rem" }}>
        Live & Upcoming Matches
      </h1>
      <MatchTable matches={data} />
    </main>
  );
}
