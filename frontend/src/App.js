import React, { useState } from 'react';
import axios from 'axios';
import styled from 'styled-components';

const ChatContainer = styled.div`
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  height: 100vh;
`;

const ChatHistory = styled.div`
  width: 80%;
  height: 70%;
  border: 1px solid #ccc;
  margin-bottom: 20px;
  overflow-y: auto;
`;

const ChatInput = styled.input`
  width: 78%;
  height: 30px;
  padding: 0 10px;
`;

const SendButton = styled.button`
  width: 20%;
  height: 36px;
`;

function App() {
  const [message, setMessage] = useState('');
  const [chatHistory, setChatHistory] = useState([]);

  const sendMessage = async () => {
    if (message.trim() !== '') {
      const response = await axios.post('API_ENDPOINT', { message });
      setChatHistory([...chatHistory, { message, from: 'user' }, { message: response.data, from: 'bot' }]);
      setMessage('');
    }
  };

  return (
    <ChatContainer>
      <ChatHistory>
        {chatHistory.map((chat, index) => (
          <div key={index}>
            <strong>{chat.from === 'user' ? 'You' : 'Bot'}:</strong> {chat.message}
          </div>
        ))}
      </ChatHistory>
      <div>
        <ChatInput
          type="text"
          value={message}
          onChange={(e) => setMessage(e.target.value)}
          onKeyPress={(e) => e.key === 'Enter' && sendMessage()}
        />
        <SendButton onClick={sendMessage}>Send</SendButton>
      </div>
    </ChatContainer>
  );
}

export default App;
