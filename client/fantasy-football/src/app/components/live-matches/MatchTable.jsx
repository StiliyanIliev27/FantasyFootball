"use client";

import { useState, useEffect } from "react";
import Image from "next/image";
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
  TablePagination,
} from "@mui/material";
import { getLiveMatches, getTeamLogo } from "../../api/football-api/index"; // Import the API functions

export default function MatchTable() {
  const [matches, setMatches] = useState([]);
  const [logos, setLogos] = useState({});
  const [page, setPage] = useState(0);
  const rowsPerPage = 10;

  // Fetch live matches and logos on component mount
  useEffect(() => {
    const fetchMatches = async () => {
      try {
        const liveMatches = await getLiveMatches();
        setMatches(liveMatches);

        // Fetch logos for each team (both home and away)
        const teamLogos = {};
        for (const match of liveMatches) {
          // For home team
          if (!teamLogos[match.home.id]) {
            const homeLogo = await getTeamLogo(match.home.id);
            teamLogos[match.home.id] = homeLogo;
          }
          // For away team
          if (!teamLogos[match.away.id]) {
            const awayLogo = await getTeamLogo(match.away.id);
            teamLogos[match.away.id] = awayLogo;
          }
        }
        setLogos(teamLogos);
      } catch (error) {
        console.error("Error fetching matches or logos", error);
      }
    };

    fetchMatches();
  }, []);

  const handleChangePage = (event, newPage) => {
    setPage(newPage);
  };

  const paginatedMatches = matches.slice(
    page * rowsPerPage,
    page * rowsPerPage + rowsPerPage
  );

  return (
    <TableContainer
      component={Paper}
      sx={{
        margin: "2em auto",
        backgroundImage: "linear-gradient(135deg, #1f1f1f, #2c2c2c)",
        borderRadius: "12px",
        boxShadow: "0px 4px 20px rgba(0,0,0,0.4)",
        width: "90%",
        maxWidth: "1000px",
        color: "#fff",
      }}
    >
      <Table>
        <TableHead>
          <TableRow>
            <TableCell sx={{ color: "#fff" }}>Time</TableCell>
            <TableCell sx={{ color: "#fff" }}>Home</TableCell>
            <TableCell sx={{ color: "#fff" }} align="center">
              Score
            </TableCell>
            <TableCell sx={{ color: "#fff" }}>Away</TableCell>
            <TableCell sx={{ color: "#fff" }}>Status</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {paginatedMatches.map((match) => {
            const isLive = match.status?.ongoing;
            return (
              <TableRow
                key={match.id}
                sx={{
                  "&:hover": { backgroundColor: "#333" },
                }}
              >
                <TableCell sx={{ color: "#fff" }}>
                  {match.status?.liveTime?.short || match.time}
                </TableCell>
                <TableCell sx={{ color: "#fff" }}>
                  {match.home.name}
                  {logos[match.home.id] && (
                    <Image
                      src={logos[match.home.id]}
                      width={30}
                      height={30}
                      style={{ objectFit: "contain", marginLeft: "10px" }}
                      alt={`${match.home.name} logo`}
                    />
                  )}
                </TableCell>
                <TableCell
                  sx={{
                    color: "#fff",
                    fontWeight: isLive ? "bold" : "normal",
                    textAlign: "center",
                  }}
                >
                  {match.home.score} - {match.away.score}
                </TableCell>
                <TableCell sx={{ color: "#fff" }}>
                  {match.away.name}
                  {logos[match.away.id] && (
                    <Image
                      src={logos[match.away.id]}
                      width={30}
                      height={30}
                      style={{ objectFit: "contain", marginLeft: "10px" }}
                      alt={`${match.away.name} logo`}
                    />
                  )}
                </TableCell>
                <TableCell sx={{ color: isLive ? "#4caf50" : "#aaa" }}>
                  {isLive
                    ? `LIVE ${match.status?.liveTime?.short || ""}`
                    : match.status?.finished
                    ? "Finished"
                    : "Upcoming"}
                </TableCell>
              </TableRow>
            );
          })}
        </TableBody>
      </Table>

      <TablePagination
        component="div"
        count={matches.length}
        page={page}
        onPageChange={handleChangePage}
        rowsPerPage={rowsPerPage}
        rowsPerPageOptions={[10]}
        sx={{ color: "#fff", backgroundColor: "#1e1e1e" }}
      />
    </TableContainer>
  );
}
