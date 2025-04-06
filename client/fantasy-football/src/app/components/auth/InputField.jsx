export default function InputField({
  label,
  type,
  name,
  value,
  onChange,
  required,
  errorMessage,
  isTouched,
}) {
  let borderColor = "border-gray-300"; // default

  if (isTouched) {
    borderColor = errorMessage ? "border-red-500" : "border-green-500";
  }

  return (
    <div className="mb-4">
      <label htmlFor={name} className="block mb-1 text-white">
        {label}:
      </label>
      <input
        id={name}
        type={type}
        name={name}
        value={value}
        onChange={onChange}
        required={required}
        className={`w-full px-3 py-2 border rounded text-white bg-transparent focus:outline-none ${borderColor}`}
      />
      {isTouched && errorMessage && (
        <p className="mt-1 text-sm text-red-400">{errorMessage}</p>
      )}
    </div>
  );
}
