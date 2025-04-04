export default function AuthForm({ type, isLoading, children, onSubmit }) {
  return (
    <form
      onSubmit={onSubmit}
      className="max-w-md mx-auto mt-10 p-6 border rounded-xl shadow-md bg-gradient-to-b from-black to-gray-800 text-white animate-slideUp"
    >
      <h2 className="text-2xl text-center font-semibold mb-4">
        {type === "sign-in" ? "Sign In" : "Sign Up"}
      </h2>

      {children}

      <button
        type="submit"
        className="w-full bg-blue-600 text-white py-2 rounded hover:bg-blue-700 cursor-pointer transition duration-200 active:opacity-50"
      >
        {isLoading
          ? type === "sign-in"
            ? "Signing in..."
            : "Signing up..."
          : type === "sign-in"
          ? "Sign In"
          : "Sign Up"}
      </button>
    </form>
  );
}
