"use client";

import Link from "next/link";
import { Button } from "@mui/material";

import { usePathname } from "next/navigation";

export default function Navbar() {
  const pathname = usePathname();

  const navLinks = [
    { href: "/", label: "Home" },
    { href: "/leagues", label: "Leagues" },
    { href: "/live-matches", label: "Live Matches" },
    { href: "/leaderboard", label: "Leaderboard" },
  ];

  return (
    <nav className="bg-gradient-to-b from-black to-gray-900 p-4 shadow-md border-b border-gray-700">
      <div className="max-w-5xl mx-auto flex justify-between items-center px-2">
        {/* Logo */}
        <Link
          href="/"
          className="text-white text-xl font-bold tracking-wider hover:opacity-90"
        >
          Fantasy ⚽ Football
        </Link>

        {/* Navigation Links */}
        <ul className="flex space-x-4">
          {navLinks.map((link) => (
            <li key={link.href}>
              <Link
                href={link.href}
                className={`transition duration-200 hover:text-blue-400 ${
                  pathname === link.href
                    ? "text-blue-400 font-semibold underline"
                    : undefined
                }`}
              >
                {link.label}
              </Link>
            </li>
          ))}
        </ul>

        {/* Auth Links */}
        <div className="flex items-center space-x-4">
          <Link href="/auth/sign-in">
            <span className="text-gray-300 hover:text-white transition duration-200 font-medium">
              Sign In
            </span>
          </Link>

          <Link href="/auth/sign-up">
            <Button
              variant="outlined"
              className="!text-white !border-gray-500 hover:!border-white hover:!bg-white hover:!text-black rounded-lg transition duration-200"
            >
              Create Account
            </Button>
          </Link>
        </div>
      </div>
    </nav>
  );
}
