import './Toaster.scss';

export default function Toaster({ type, message, onClose }) {
  return (
    <div className="toast-wrapper">
      <aside role="alert" className={`toast ${type}`}>
        <img src={`/assets/icons/sprite-icons-small.svg#${type}`} width="32" height="32" alt="alert icon" />
        <p className="message">{message}</p>
        <button className="close-button" onClick={onClose}>
          <svg className="close-button__icon" width="24" height="24">
            <use xlinkHref="/assets/icons/sprite-icons-small.svg#cross" />
          </svg>
        </button>
      </aside>
    </div>
  );
}
