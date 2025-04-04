export default function InputField({
  label,
  type,
  name,
  value,
  onChange,
  error,
  required,
}) {
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
        className={`w-full px-3 py-2 border rounded text-white ${
          error ? "border-red-500" : "border-gray-300"
        }`}
      />
    </div>
  );
}
