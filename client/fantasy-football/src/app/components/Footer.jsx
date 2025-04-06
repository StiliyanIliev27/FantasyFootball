export default function Footer() {
  return (
    <footer className="bg-black text-white py-10">
      <div className="max-w-7xl mx-auto px-4">
        <div className="flex flex-col md:flex-row justify-between items-center gap-6 text-center md:text-left">
          {/* Logo or Name */}
          <div>
            <h2 className="text-2xl font-bold">Fantasy Football</h2>
            <p className="text-sm text-gray-400 mt-1">
              Build. Compete. Win. ⚽
            </p>
          </div>

          {/* Navigation Links */}
          <div>
            <ul className="flex flex-col md:flex-row gap-4 text-sm text-gray-300">
              <li><a href="/about" className="hover:text-white">About</a></li>
              <li><a href="/contact" className="hover:text-white">Contact</a></li>
              <li><a href="/privacy" className="hover:text-white">Privacy Policy</a></li>
              <li><a href="/terms" className="hover:text-white">Terms of Service</a></li>
            </ul>
          </div>

          {/* Contact Info */}
          <div className="text-sm text-gray-400">
            <p>Email: support@fantasyfootball.com</p>
            <p>Phone: +1 (800) 123-4567</p>
          </div>
        </div>

        {/* Bottom Line */}
        <div className="mt-8 border-t border-gray-700 pt-4 text-center text-xs text-gray-500">
          <p>&copy; 2025 Fantasy Football. All rights reserved.</p>
        </div>
      </div>
    </footer>
  );
}
