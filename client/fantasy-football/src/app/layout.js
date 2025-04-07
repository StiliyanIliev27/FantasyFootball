import { Provider } from "react-redux";
import { store } from "../lib/store/store";

import Footer from "./components/Footer";
import Navbar from "./components/Navbar";
import "./globals.css";
import StoreProvider from "./StoreProvider";

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body
        suppressHydrationWarning
        className="bg-gradient-to-b from-black to-gray-800 text-white"
      >
        <Navbar />
        <main className="min-h-screen">
          <StoreProvider>
            {children}
          </StoreProvider>
        </main>
        <Footer />
      </body>
    </html>
  );
}
