"use client";

import Image from "next/image";
import Link from "next/link";

export default function LandingPage() {
  return (
    <section className="relative bg-gradient-to-b from-black to-gray-900 text-white min-h-screen overflow-hidden">
      {/* Hero Section */}
      <div className="max-w-7xl mx-auto px-4 py-32 grid grid-cols-1 md:grid-cols-2 gap-12 items-center">
        {/* Text & Logo */}
        <div className="text-center md:text-left">
          <h1 className="text-5xl font-extrabold mb-4 leading-tight">
            Welcome to Fantasy Football
          </h1>
          <p className="text-lg text-gray-300 mb-8 max-w-md">
            Build your dream team, strategize like a pro, and climb to the top of the leaderboard. The game is yours.
          </p>
          <Link href="/auth/sign-up">
            <button className="bg-blue-600 text-white cursor-pointer py-3 px-8 rounded-full text-lg hover:bg-blue-700 transition duration-300 shadow-lg">
              Get Started
            </button>
          </Link>
        </div>

        {/* Faceless Footballer Image */}
        <div className="hidden md:block relative w-full h-96">
          <Image
            src="/hero-image.png"
            alt="Faceless Footballer"
            width={400}
            height={200}
            objectFit="contain"
          />
        </div>
      </div>

      {/* Features Section */}
      <div className="py-20 bg-gray-800">
        <div className="max-w-6xl mx-auto px-4 text-center">
          <h2 className="text-3xl font-semibold mb-10">
            Why Choose Fantasy Football?
          </h2>
          <div className="grid grid-cols-1 md:grid-cols-3 gap-8">
            {[
              {
                title: "Customize Your Team",
                text: "Hand-pick your roster from top players and create your dream lineup."
              },
              {
                title: "Challenge Friends",
                text: "Compete in leagues, rise in the ranks, and dominate the competition."
              },
              {
                title: "Live Stats & Updates",
                text: "Stay in the know with real-time player performance and match updates."
              }
            ].map(({ title, text }, i) => (
              <div key={i} className="bg-gray-700 p-6 rounded-xl shadow-md">
                <h3 className="text-xl font-bold mb-3">{title}</h3>
                <p className="text-gray-300">{text}</p>
              </div>
            ))}
          </div>
        </div>
      </div>

      {/* Final CTA Section */}
      <div className="bg-blue-800 py-16 text-center">
        <h2 className="text-3xl font-semibold text-white mb-6">
          Ready to draft your legacy?
        </h2>
        <Link href="/auth/sign-up">
          <button className="bg-white text-blue-800 cursor-pointer font-semibold py-3 px-10 rounded-full text-lg hover:bg-gray-100 transition duration-300 shadow-xl">
            Sign Up Now
          </button>
        </Link>
      </div>
    </section>
  );
}
