export default function AuthForm({ type, isLoading, children, onSubmit }) {
  return (
    <form
      onSubmit={onSubmit}
      className="max-w-md mx-auto mt-12 p-8 border border-gray-700 rounded-xl shadow-lg bg-gradient-to-b from-black to-gray-800 text-white transition-all duration-300 ease-in-out animate-slideUp"
    >
      <h2 className="text-3xl text-center font-semibold mb-6 text-gray-200">
        {type === "sign-in" ? "Sign In" : "Sign Up"}
      </h2>

      {children}

      <div className="mt-4">
        <button
          type="submit"
          className="w-full bg-blue-600 cursor-pointer text-white py-3 rounded-lg font-semibold hover:bg-blue-700 focus:ring-4 focus:ring-blue-500 active:opacity-75 transition duration-300"
        >
          {isLoading
            ? type === "sign-in"
              ? "Signing in..."
              : "Signing up..."
            : type === "sign-in"
            ? "Sign In"
            : "Sign Up"}
        </button>
      </div>
    </form>
  );
}
