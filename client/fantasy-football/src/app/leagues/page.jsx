import { getLeagues } from "../api/football";
import Image from "next/image";
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
} from "@mui/material";

export default async function Leagues() {
  const leagues = await getLeagues();

  return (
    <TableContainer
      component={Paper}
      className="animate-slideUp"
      sx={{
        backgroundImage: "linear-gradient(135deg, #1f1f1f, #2c2c2c)",
        color: "#fff",
        width: "50%",
        margin: "4em auto",
        boxShadow: "0px 4px 20px rgba(0,0,0,0.5)",
        borderRadius: "12px",
      }}
    >
      <Table sx={{ minWidth: 400 }} aria-label="league table">
        <TableHead>
          <TableRow>
            <TableCell sx={{ color: "#fff" }}>#</TableCell>
            <TableCell sx={{ color: "#fff" }} align="center">
              League Name
            </TableCell>
            <TableCell sx={{ color: "#fff" }} align="left">
              Logo
            </TableCell>
            <TableCell sx={{ color: "#fff" }} align="center">
              Country
            </TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {leagues?.map((league, index) => (
            <TableRow
              key={league.id}
              sx={{
                "&:last-child td, &:last-child th": { border: 0 },
                backgroundColor: "transparent",
                "&:hover": {
                  backgroundColor: "#3a3a3a",
                },
              }}
            >
              <TableCell sx={{ color: "#fff" }} component="th" scope="row">
                {index + 1}
              </TableCell>
              <TableCell sx={{ color: "#fff" }} align="center">
                {league.name}
              </TableCell>
              <TableCell align="center">
                <Image
                  src={league.logoUrl}
                  width={40}
                  height={40}
                  style={{ objectFit: "contain" }}
                  alt={`${league.name} logo`}
                  loading="lazy"
                />
              </TableCell>
              <TableCell sx={{ color: "#fff" }} align="center">
                {league.country}
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}
